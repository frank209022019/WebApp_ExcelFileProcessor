using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp_ExcelFileProcessor.Data;
using WebApp_ExcelFileProcessor.Models;
using WebApp_ExcelFileProcessor.ViewModels;

namespace WebApp_ExcelFileProcessor.Controllers
{
    [Authorize]
    public class BaseClassController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public BaseClassController(ILogger<HomeController> logger, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        #region Views

        [Authorize]
        public IActionResult UploadBaseClass()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UploadBaseClass(List<IFormFile> files)
        {
            try
            {
                //  get file details
                FileDetailsViewModel model = new FileDetailsViewModel()
                {
                    DateUploaded = DateTime.Now
                };
                if (files.Count() > 0)
                {
                    var file = files.FirstOrDefault();
                    using (var stream = new MemoryStream())
                    {
                        await file.CopyToAsync(stream);
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                        using (ExcelPackage package = new ExcelPackage(stream))
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
                            model.TotalColumns = worksheet.Dimension.End.Column.ToString();
                            model.TotalRows = worksheet.Dimension.End.Row.ToString();
                            model.FileName = file.FileName;
                        }
                    }
                }

                //  save file details to database temp
                var processResult = await ProcessBaseClassUploadFile(files.FirstOrDefault());
                if (!processResult.ResponseValid)
                    throw new Exception(processResult.ResponseMessage);

                return Ok(new { success = true, message = "All files uploaded successfully!", result = model });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }

        [Authorize]
        public IActionResult UploadBaseClassResult()
        {
            try
            {
                UploadBaseClassResultViewModel model = new UploadBaseClassResultViewModel();

                var tempResults = _context.StudentTemps.ToList();
                if (tempResults.Count() > 0)
                {
                    //  add to different model lists
                    var createTemp = tempResults.Where(i => i.RowType == 'C').ToList();
                    if (createTemp != null && createTemp.Count() > 0)
                        model.CreateList = createTemp;
                    else
                        model.CreateList = new List<StudentTemp>();

                    var updateTemp = tempResults.Where(i => i.RowType == 'U').ToList();
                    if (updateTemp != null && updateTemp.Count() > 0)
                        model.UpdateList = updateTemp;
                    else
                        model.UpdateList = new List<StudentTemp>();

                    var errorTemp = tempResults.Where(i => i.RowType == 'E').ToList();
                    if (errorTemp != null && errorTemp.Count() > 0)
                        model.ErrorList = errorTemp;
                    else
                        model.ErrorList = new List<StudentTemp>();

                    return View(model);
                }
                else
                {
                    return RedirectToAction("UploadBaseClass", "BaseClass");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return RedirectToAction("UploadBaseClass", "BaseClass");
            }
        }

        [Authorize]
        public IActionResult ManageBaseClass()
        {
            try
            {
                var currentStudents = _context.Students.Where(i => !i.IsDeleted).ToList();
                if (currentStudents.Count() == 0)
                    throw new Exception("No student records found.");

                return View(currentStudents);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View(new List<Student>());
            }
        }

        [Authorize]
        public IActionResult AddStudent()
        {
            Student model = new Student()
            {
                IsDeleted = false,
                DateCreated = DateTime.Now
            };
            model = UpdateStudentWithLists(model);
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddStudent(Student model)
        {
            try
            {
                _context.Students.Add(model);
                _context.SaveChanges();

                return RedirectToAction("ManageBaseClass");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return RedirectToAction("ManageBaseClass");
            }
        }

        [Authorize]
        public IActionResult UpdateStudent(String StudentId)
        {
            try
            {
                var model = _context.Students.SingleOrDefault(i => i.StudentId.ToString().ToUpper() == StudentId.ToUpper());
                if (model != null)
                {
                    model = UpdateStudentWithLists(model);
                    return View(model);
                }
                else
                {
                    return View(new Student() { });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View(new Student() { });
            }
        }

        [Authorize]
        [HttpPost]
        public IActionResult UpdateStudent(Student model)
        {
            try
            {
                var currModel = _context.Students.SingleOrDefault(i => i.StudentId == model.StudentId);
                currModel.StudentNr = model.StudentNr;
                currModel.QRCode = model.QRCode;
                currModel.FirstName = model.FirstName;
                currModel.LastName = model.LastName;
                currModel.GenderId = model.GenderId;
                currModel.StudentClassId = model.StudentClassId;
                currModel.StudentGroupId = model.StudentGroupId;
                _context.Students.Update(currModel);
                _context.SaveChanges();

                return RedirectToAction("ManageBaseClass");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return RedirectToAction("ManageBaseClass");
            }
        }

        [Authorize]
        public IActionResult DeleteStudent(String StudentId)
        {
            try
            {
                var model = _context.Students.SingleOrDefault(i => i.StudentId.ToString().ToUpper() == StudentId.ToUpper());
                if (model != null)
                    return View(model);
                else
                    return View(new Student() { });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View(new Student() { });
            }
        }

        [Authorize]
        [HttpPost]
        public IActionResult DeleteStudent(Student model)
        {
            try
            {
                var currModel = _context.Students.SingleOrDefault(i => i.StudentId == model.StudentId && !i.IsDeleted);
                currModel.IsDeleted = true;
                _context.Students.Update(currModel);
                _context.SaveChanges();

                return RedirectToAction("ManageBaseClass");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return RedirectToAction("ManageBaseClass");
            }
        }

        [Authorize]
        public IActionResult ViewStudent(String StudentId)
        {
            try
            {
                var model = _context.Students.SingleOrDefault(i => i.StudentId.ToString().ToUpper() == StudentId.ToUpper());
                if (model != null)
                    return View(model);
                else
                    return View(new Student() { });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View(new Student() { });
            }
        }

        #endregion Views

        #region Utilities

        [Authorize]
        private async Task<UploadBaseClassProcessViewModel> ProcessBaseClassUploadFile(IFormFile file)
        {
            try
            {
                //  Validate Template
                var validTemplate = await ValidateFileTemplate(file);
                if (!validTemplate)
                    throw new Exception("Invalid template used.");

                //  Clear all temp records
                var currentTempList = _context.StudentTemps.ToList();
                if (currentTempList.Count() > 0)
                {
                    _context.StudentTemps.RemoveRange(currentTempList);
                    _context.SaveChanges();
                }

                //  Database Lists
                var studentGroupList = _context.StudentGroups.ToList();
                var studentClassList = _context.StudentClasses.ToList();
                var genderList = _context.Genders.ToList();

                //  Lists for result view
                UploadBaseClassProcessViewModel returnValue = new UploadBaseClassProcessViewModel()
                {
                    ResponseId = null,
                    ResponseValid = true,
                    ResponseDateTime = DateTime.Now,
                    ResponseMessage = "File processing successful.",
                    SuccessList = new List<StudentTemp>(),
                    ErrorList = new List<StudentTemp>()
                };

                //  Process document
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    using (ExcelPackage package = new ExcelPackage(stream))
                    {
                        //  Get the first worksheet in the workbook
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        int colCount = worksheet.Dimension.End.Column;
                        int rowCount = worksheet.Dimension.End.Row;

                        //  Loop through rows
                        if (rowCount > 0)
                        {
                            for (int row = 6; row <= rowCount; row++)
                            {
                                //  StudentTemp
                                Boolean rowHasError = false;
                                StudentTemp tempModel = new StudentTemp()
                                {
                                    RowNumber = row,
                                    IsDeleted = false,
                                    DateCreated = DateTime.Now
                                };

                                try
                                {
                                    //  Get values from row/col
                                    //Col2        Gold            StudentColor
                                    //Col3        G1                 StudentGroup
                                    //Col4        7                   StudentNr
                                    //Col5       CIN500       QR Code
                                    //Col6        Surname
                                    //Col7        Name
                                    //Col8        Gender
                                    //Col9        8A              StudentClass

                                    //  Check if current rows columns have null values
                                    for (int col = 2; col <= 9; col++)
                                    {
                                        if (worksheet.Cells[row, col].Value == null)
                                            rowHasError = true;
                                    }                                   

                                    //  Student Group
                                    if (worksheet.Cells[row, 3].Value != null)
                                    {
                                        var valueStudentGroup = worksheet.Cells[row, 3].Value;
                                        if (valueStudentGroup != null)
                                            tempModel.StudentGroupId = studentGroupList.SingleOrDefault(i => i.DisplayName.ToUpper() == valueStudentGroup.ToString().ToUpper()).StudentGroupId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "StudentGroup"));
                                    }

                                    //  Student Nr
                                    if (worksheet.Cells[row, 4].Value != null)
                                    {
                                        var valueStudentNr = worksheet.Cells[row, 4].Value;
                                        if (valueStudentNr != null)
                                            tempModel.StudentNr = Convert.ToInt32(valueStudentNr);
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "StudentNr"));
                                    }

                                    //  QR Code
                                    if (worksheet.Cells[row, 5].Value != null)
                                    {
                                        var valueQRCode = worksheet.Cells[row, 5].Value;
                                        if (valueQRCode != null)
                                            tempModel.QRCode = valueQRCode.ToString().ToUpper();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "QR"));
                                    }

                                    //  Last Name
                                    if (worksheet.Cells[row, 6].Value != null)
                                    {
                                        var valueLastName = worksheet.Cells[row, 6].Value;
                                        if (valueLastName != null)
                                            tempModel.LastName = valueLastName.ToString().ToUpper();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "LastName"));
                                    }

                                    //  First Name
                                    if (worksheet.Cells[row, 7].Value != null)
                                    {
                                        var valueFirstName = worksheet.Cells[row, 7].Value;
                                        if (valueFirstName != null)
                                            tempModel.FirstName = valueFirstName.ToString().ToUpper();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "FirstName"));
                                    }

                                    //  Gender
                                    if (worksheet.Cells[row, 8].Value != null)
                                    {
                                        var valueGender = worksheet.Cells[row, 8].Value;
                                        if (valueGender != null)
                                            tempModel.GenderId = genderList.FirstOrDefault(i => i.GenderChar.ToString().ToUpper() == valueGender.ToString().ToUpper()).GenderId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "Gender"));
                                    }

                                    //  Student Class
                                    if (worksheet.Cells[row, 9].Value != null)
                                    {
                                        var valueStudentClass = worksheet.Cells[row, 9].Value;
                                        if (valueStudentClass != null)
                                            tempModel.StudentClassId = studentClassList.FirstOrDefault(i => i.DisplayName.ToUpper() == valueStudentClass.ToString().ToUpper()).StudentClassId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "StudentClass"));
                                    }

                                    //  Determine if row is create, update or error
                                    if (!rowHasError)
                                    {
                                        //  check if similar records already exists in the database && needs create or update
                                        var alreadyExists = CheckIfStudentExisits(tempModel);
                                        if (alreadyExists)
                                        {
                                            //  further process to check if row needs to be updated
                                            //  incomplete validation - not able to create with upload
                                            var needsUpdate = CheckIfStudentNeedsUpdate(tempModel);
                                            if (needsUpdate)
                                                tempModel.RowType = 'U';
                                            else
                                                tempModel.RowType = 'X';
                                        }
                                        else
                                        {
                                            tempModel.RowType = 'C';
                                        }
                                        returnValue.SuccessList.Add(tempModel);
                                    }
                                    else
                                    {
                                        //  add row to a error list
                                        tempModel.RowType = 'E';
                                        returnValue.ErrorList.Add(tempModel);
                                    }
                                }
                                catch
                                {
                                    tempModel.RowType = 'E';
                                    returnValue.ErrorList.Add(tempModel);
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("No rows found in the file.");
                        }
                    }
                }

                //  Add lists to database
                if (returnValue.ErrorList.Count() > 0)
                {
                    _context.StudentTemps.AddRange(returnValue.ErrorList);
                    _context.SaveChanges();
                }
                if (returnValue.SuccessList.Count() > 0)
                {
                    _context.StudentTemps.AddRange(returnValue.SuccessList);
                    _context.SaveChanges();
                }

                return returnValue;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new UploadBaseClassProcessViewModel() { ResponseId = null, ResponseValid = false, ResponseDateTime = DateTime.Now, ResponseMessage = ex.Message, SuccessList = new List<StudentTemp>(), ErrorList = new List<StudentTemp>() };
            }
        }

        [Authorize]
        private async Task<Boolean> ValidateFileTemplate(IFormFile file)
        {
            try
            {
                //  A3 = GR
                //  B3 = NR
                //  C3  =  QR CODE

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    using (ExcelPackage package = new ExcelPackage(stream))
                    {
                        //  Get the first worksheet in the workbook
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        int colCount = worksheet.Dimension.End.Column;
                        int rowCount = worksheet.Dimension.End.Row;

                        var validateGr = worksheet.Cells["A3"].Value;
                        if (validateGr == null || validateGr.ToString().ToUpper() != "GR")
                            throw new Exception("Invalid template used");

                        var validateNr = worksheet.Cells["B3"].Value;
                        if (validateNr == null || validateNr.ToString().ToUpper() != "NR")
                            throw new Exception("Invalid template used");

                        var validateQrCode = worksheet.Cells["C3"].Value;
                        if (validateQrCode == null || validateQrCode.ToString().ToUpper() != "QR CODE")
                            throw new Exception("Invalid template used");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }
        }

        [Authorize]
        private Boolean CheckIfStudentExisits(StudentTemp tempModel)
        {
            try
            {
                //return _context.Students.Any(i => i.QRCode.ToUpper() == tempModel.QRCode.ToUpper() && i.FirstName.ToUpper() == tempModel.FirstName.ToUpper()
                //                                                                    && i.LastName.ToUpper() == tempModel.LastName.ToUpper());
                return _context.Students.Any(i => i.QRCode.ToUpper() == tempModel.QRCode.ToUpper() && !i.IsDeleted);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }
        }

        [Authorize]
        private Boolean CheckIfStudentNeedsUpdate(StudentTemp tempModel)
        {
            try
            {
                Boolean needsUpdate = false;
                Int32 totalUpdates = 0;
                var currModel = _context.Students.SingleOrDefault(i => i.QRCode.ToUpper() == tempModel.QRCode.ToUpper() && !i.IsDeleted);
                if (currModel != null)
                {
                    //  StudentNr
                    if (currModel.StudentNr.ToString().ToUpper() != tempModel.StudentNr.ToString().ToUpper())
                        totalUpdates++;

                    //  QRCode
                    if (currModel.QRCode.ToUpper() != tempModel.QRCode.ToUpper())
                        totalUpdates++;

                    //  LastName
                    if (currModel.LastName.ToUpper() != tempModel.LastName.ToUpper())
                        totalUpdates++;

                    //  FirstName
                    if (currModel.FirstName.ToUpper() != tempModel.FirstName.ToUpper())
                        totalUpdates++;

                    //  GenderId
                    if (currModel.GenderId.ToString().ToUpper() != tempModel.GenderId.ToString().ToUpper())
                        totalUpdates++;            

                    //  StudentClassId
                    if (currModel.StudentClassId.ToString().ToUpper() != tempModel.StudentClassId.ToString().ToUpper())
                        totalUpdates++;

                    //  StudentGroupId
                    if (currModel.StudentGroupId.ToString().ToUpper() != tempModel.StudentGroupId.ToString().ToUpper())
                        totalUpdates++;
                }

                if (totalUpdates > 0)
                    needsUpdate = true;
                return needsUpdate;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }
        }

        [Authorize]
        private Student UpdateStudentWithLists(Student model)
        {
            try
            {
                model.GenderList = _context.Genders.ToList().Count() < 0 ? new List<SelectListItem>() : _context.Genders.ToList().Select(i => new SelectListItem { Value = i.GenderId.ToString(), Text = i.GenderName }).OrderByDescending(i => i.Text);   
                model.ClassList = _context.StudentClasses.ToList().Count() < 0 ? new List<SelectListItem>() : _context.StudentClasses.ToList().Select(i => new SelectListItem { Value = i.StudentClassId.ToString(), Text = i.DisplayName }).OrderByDescending(i => i.Text);
                model.GroupList = _context.StudentGroups.ToList().Count() < 0 ? new List<SelectListItem>() : _context.StudentGroups.ToList().Select(i => new SelectListItem { Value = i.StudentGroupId.ToString(), Text = i.DisplayName }).OrderByDescending(i => i.Text);
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                model.GenderList = new List<SelectListItem>();
                model.ColorList = new List<SelectListItem>();
                model.ClassList = new List<SelectListItem>();
                model.GroupList = new List<SelectListItem>();
                return model;
            }
        }

        [Authorize]
        [HttpGet]
        public List<StudentTempViewModel> GetCreateStudentList()
        {
            try
            {
                var tempResults = _context.StudentTemps.ToList();
                var returnList = tempResults.Where(i => i.RowType == 'C').ToList();
                if (returnList.Count() > 0)
                {
                    return returnList.Select(i => new StudentTempViewModel()
                    {
                        StudentTempId = i.StudentTempId.ToString(),
                        RowNumber = i.RowNumber.ToString(),
                        QRCode = i.QRCode == null ? String.Empty : i.QRCode.ToString(),
                        StudentNr = i.StudentNr == null ? String.Empty : i.StudentNr.ToString(),
                        FirstName = i.FirstName == null ? String.Empty : i.FirstName.ToString(),
                        LastName = i.LastName == null ? String.Empty : i.LastName.ToString(),
                        GenderGenderName = i.GenderId == null ? String.Empty : i.Gender.GenderName.ToString(),
                        StudentClassdisplayName = i.StudentClassId == null ? String.Empty : i.StudentClass.DisplayName.ToString(),           
                        StudentGroupDisplayName = i.StudentGroupId == null ? String.Empty : i.StudentGroup.DisplayName.ToString()
                    }).ToList();
                }
                else
                {
                    return new List<StudentTempViewModel>();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<StudentTempViewModel>();
            }
        }

        [Authorize]
        [HttpGet]
        public List<StudentTempViewModel> GetUpdateStudentList()
        {
            try
            {
                var tempResults = _context.StudentTemps.ToList();
                var returnList = tempResults.Where(i => i.RowType == 'U').ToList();
                if (returnList.Count() > 0)
                {
                    return returnList.Select(i => new StudentTempViewModel()
                    {
                        StudentTempId = i.StudentTempId.ToString(),
                        RowNumber = i.RowNumber.ToString(),
                        QRCode = i.QRCode == null ? String.Empty : i.QRCode.ToString(),
                        StudentNr = i.StudentNr == null ? String.Empty : i.StudentNr.ToString(),
                        FirstName = i.FirstName == null ? String.Empty : i.FirstName.ToString(),
                        LastName = i.LastName == null ? String.Empty : i.LastName.ToString(),
                        GenderGenderName = i.GenderId == null ? String.Empty : i.Gender.GenderName.ToString(),
                        StudentClassdisplayName = i.StudentClassId == null ? String.Empty : i.StudentClass.DisplayName.ToString(),
                        StudentGroupDisplayName = i.StudentGroupId == null ? String.Empty : i.StudentGroup.DisplayName.ToString()
                    }).ToList();
                }
                else
                {
                    return new List<StudentTempViewModel>();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<StudentTempViewModel>();
            }
        }

        [Authorize]
        [HttpGet]
        public List<StudentTempViewModel> GetRowErrorStudentList()
        {
            try
            {
                var tempResults = _context.StudentTemps.ToList();
                var returnList = tempResults.Where(i => i.RowType == 'E').ToList();
                if (returnList.Count() > 0)
                {
                    return returnList.Select(i => new StudentTempViewModel()
                    {
                        StudentTempId = i.StudentTempId.ToString(),
                        RowNumber = i.RowNumber.ToString(),
                        QRCode = i.QRCode == null ? String.Empty : i.QRCode.ToString(),
                        StudentNr = i.StudentNr == null ? String.Empty : i.StudentNr.ToString(),
                        FirstName = i.FirstName == null ? String.Empty : i.FirstName.ToString(),
                        LastName = i.LastName == null ? String.Empty : i.LastName.ToString(),
                        GenderGenderName = i.GenderId == null ? String.Empty : i.Gender.GenderName.ToString(),
                        StudentClassdisplayName = i.StudentClassId == null ? String.Empty : i.StudentClass.DisplayName.ToString(),
                        StudentGroupDisplayName = i.StudentGroupId == null ? String.Empty : i.StudentGroup.DisplayName.ToString()
                    }).ToList();
                }
                else
                {
                    return new List<StudentTempViewModel>();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<StudentTempViewModel>();
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult CompleteProcessBaseStudentUpload()
        {
            try
            {
                var tempList = _context.StudentTemps.ToList();
                if (tempList.Count() > 0)
                {
                    //  create new records
                    var createList = tempList.Where(i => i.RowType == 'C').ToList();
                    if (createList.Count() > 0)
                    {
                        List<Student> studentList = new List<Student>();
                        foreach (var item in createList)
                        {
                            studentList.Add(new Student()
                            {
                                StudentNr = (Int32)item.StudentNr,
                                QRCode = item.QRCode,
                                LastName = item.LastName,
                                FirstName = item.FirstName,
                                GenderId = (Guid)item.GenderId,
                                StudentClassId = (Guid)item.StudentClassId,
                                StudentGroupId = (Guid)item.StudentGroupId,
                                IsDeleted = false,
                                DateCreated = DateTime.Now
                            });
                        }
                        _context.Students.AddRange(studentList);
                        _context.SaveChanges();
                    }

                    //  update current records
                    var updateList = tempList.Where(i => i.RowType == 'U').ToList();
                    if (updateList.Count() > 0)
                    {
                        foreach (var item in updateList)
                        {
                            //  get student records (with QRCode)
                            var currStudent = _context.Students.SingleOrDefault(i => i.QRCode.ToUpper() == item.QRCode.ToUpper() && !i.IsDeleted);
                            if (currStudent != null)
                            {
                                currStudent.StudentNr = (Int32)item.StudentNr;
                                currStudent.QRCode = item.QRCode;
                                currStudent.LastName = item.LastName;
                                currStudent.FirstName = item.FirstName;
                                currStudent.GenderId = (Guid)item.GenderId;
                                currStudent.StudentClassId = (Guid)item.StudentClassId;
                                currStudent.StudentGroupId = (Guid)item.StudentGroupId;
                                _context.SaveChanges();
                            }
                        }
                    }
                }

                //  clear temp list
                _context.StudentTemps.RemoveRange(tempList);
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest("Error occurred while trying to complete processing records.");
            }
        }

        [Authorize]
        [HttpGet]
        public List<StudentViewModel> GetStudentClassList()
        {
            try
            {
                var studentList = _context.Students.Where(i => !i.IsDeleted).ToList();
                if (studentList.Count() == 0)
                    throw new Exception("No students found.");
                return studentList.Select(i => new StudentViewModel()
                {
                    StudentId = i.StudentId.ToString(),
                    QRCode = i.QRCode == null ? String.Empty : i.QRCode.ToString(),
                    StudentNr = i.StudentNr <= 0 ? String.Empty : i.StudentNr.ToString(),
                    FirstName = i.FirstName == null ? String.Empty : i.FirstName.ToString(),
                    LastName = i.LastName == null ? String.Empty : i.LastName.ToString(),
                    GenderGenderName = i.GenderId == Guid.Empty ? String.Empty : i.Gender.GenderName.ToString(),
                    StudentClassdisplayName = i.StudentClassId == Guid.Empty ? String.Empty : i.StudentClass.DisplayName.ToString(),
                    StudentGroupDisplayName = i.StudentGroupId == Guid.Empty ? String.Empty : i.StudentGroup.DisplayName.ToString(),
                    DateCreated = i.DateCreated.ToShortDateString()
                }).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<StudentViewModel>();
            }
        }

        [Authorize]
        [HttpDelete]
        public IActionResult DeleteStudentTempRecord(String studentTempId)
        {
            try
            {
                if (studentTempId == null)
                    return BadRequest("Invalid parameter.");
                var record = _context.StudentTemps.SingleOrDefault(i => i.StudentTempId.ToString().ToUpper() == studentTempId.ToUpper());
                if (record == null)
                    return BadRequest("Error occurred while trying to delete the record");
                _context.StudentTemps.Remove(record);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest("Error occurred while trying to delete the record");
            }
        }

        #endregion Utilities
    }
}