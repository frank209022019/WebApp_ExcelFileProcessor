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
                var moduleCodeList = _context.ModuleCodes.ToList();

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
                            for (int row = 4; row <= rowCount; row++)
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
                                    /*  GR (wont be used)
                                     *  NR
                                     *  QR CODE
                                     *  SURNAME
                                     *  NAME
                                     *  M/F
                                     *  CLASS
                                     *  GROUP
                                     *
                                     *  MON
                                     *  SUBJ
                                     *  TUE
                                     *  SUBJ
                                     *  WED
                                     *  SUBJ
                                     *  THUR
                                     *  SUBJ
                                     *  FRI
                                     *  SUBJ
                                     *  EXTRA1
                                     *  SUBJExtra1
                                      *  EXTRA2
                                     *  SUBJExtra2
                                    *  EXTRA3
                                     *  SUBJExtra3
                                     */

                                    //  Check if current rows columns have null values
                                    //  Student Information Compulsory
                                    for (int col = 1; col <= 8; col++)
                                    {
                                        if (worksheet.Cells[row, col].Value == null)
                                            rowHasError = true;
                                    }

                                    //  Monday-Friday Module Code
                                    if (worksheet.Cells[row, 9].Value == null)
                                        rowHasError = true;
                                    if (worksheet.Cells[row, 11].Value == null)
                                        rowHasError = true;
                                    if (worksheet.Cells[row, 13].Value == null)
                                        rowHasError = true;
                                    if (worksheet.Cells[row, 15].Value == null)
                                        rowHasError = true;
                                    if (worksheet.Cells[row, 17].Value == null)
                                        rowHasError = true;

                                    //  Grade String
                                    if (worksheet.Cells[row, 1].Value != null)
                                    {
                                        var gradeString = worksheet.Cells[row, 1].Value;
                                        if (gradeString != null)
                                            tempModel.GradeString = Convert.ToString(gradeString).ToUpper();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "GradeString"));
                                    }

                                    //  Student Nr
                                    if (worksheet.Cells[row, 2].Value != null)
                                    {
                                        var valueStudentNr = worksheet.Cells[row, 2].Value;
                                        if (valueStudentNr != null)
                                            tempModel.StudentNr = Convert.ToInt32(valueStudentNr);
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "StudentNr"));
                                    }

                                    //  QR Code
                                    if (worksheet.Cells[row, 3].Value != null)
                                    {
                                        var valueQRCode = worksheet.Cells[row, 3].Value;
                                        if (valueQRCode != null)
                                            tempModel.QRCode = valueQRCode.ToString().ToUpper();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "QRCode"));
                                    }

                                    //  Last Name
                                    if (worksheet.Cells[row, 4].Value != null)
                                    {
                                        var valueLastName = worksheet.Cells[row, 4].Value;
                                        if (valueLastName != null)
                                            tempModel.LastName = valueLastName.ToString().ToUpper();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "LastName"));
                                    }

                                    //  First Name
                                    if (worksheet.Cells[row, 5].Value != null)
                                    {
                                        var valueFirstName = worksheet.Cells[row, 5].Value;
                                        if (valueFirstName != null)
                                            tempModel.FirstName = valueFirstName.ToString().ToUpper();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "FirstName"));
                                    }

                                    //  Gender
                                    if (worksheet.Cells[row, 6].Value != null)
                                    {
                                        var valueGender = worksheet.Cells[row, 6].Value;
                                        if (valueGender != null)
                                            tempModel.GenderId = genderList.FirstOrDefault(i => i.GenderChar.ToString().ToUpper() == valueGender.ToString().ToUpper()).GenderId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "Gender"));
                                    }

                                    //  Student Class
                                    if (worksheet.Cells[row, 7].Value != null)
                                    {
                                        var valueStudentClass = worksheet.Cells[row, 7].Value;
                                        if (valueStudentClass != null)
                                            tempModel.StudentClassId = studentClassList.FirstOrDefault(i => i.DisplayName.ToUpper() == valueStudentClass.ToString().ToUpper()).StudentClassId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "StudentClass"));
                                    }

                                    //  Student Group
                                    if (worksheet.Cells[row, 8].Value != null)
                                    {
                                        var valueStudentGroup = worksheet.Cells[row, 8].Value;
                                        if (valueStudentGroup != null)
                                            tempModel.StudentGroupId = studentGroupList.SingleOrDefault(i => i.DisplayName.ToUpper() == valueStudentGroup.ToString().ToUpper()).StudentGroupId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "StudentGroup"));
                                    }

                                    //  Monday Module Code
                                    if (worksheet.Cells[row, 9].Value != null)
                                    {
                                        var moduleCode = worksheet.Cells[row, 9].Value;
                                        if (moduleCode != null)
                                            tempModel.MondayModuleCodeId = moduleCodeList.SingleOrDefault(i => i.ModuleCodeName.ToUpper() == moduleCode.ToString().ToUpper()).ModuleCodeId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "MondayModuleCodeId"));
                                    }

                                    //  Monday Subject String
                                    if (worksheet.Cells[row, 10].Value != null)
                                    {
                                        var subjectString = worksheet.Cells[row, 10].Value;
                                        if (subjectString != null)
                                            tempModel.MondaySubjString = Convert.ToString(subjectString).ToUpper();
                                        else
                                            tempModel.MondaySubjString = String.Empty;
                                    }

                                    //  Tuesday Module Code
                                    if (worksheet.Cells[row, 11].Value != null)
                                    {
                                        var moduleCode = worksheet.Cells[row, 11].Value;
                                        if (moduleCode != null)
                                            tempModel.TuesdayModuleCodeId = moduleCodeList.SingleOrDefault(i => i.ModuleCodeName.ToUpper() == moduleCode.ToString().ToUpper()).ModuleCodeId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "TuesdayModuleCodeId"));
                                    }

                                    //  Tuesday Subject String
                                    if (worksheet.Cells[row, 12].Value != null)
                                    {
                                        var subjectString = worksheet.Cells[row, 12].Value;
                                        if (subjectString != null)
                                            tempModel.TuesdaySubjString = Convert.ToString(subjectString).ToUpper();
                                        else
                                            tempModel.TuesdaySubjString = String.Empty;
                                    }

                                    //  Wednesday Module Code
                                    if (worksheet.Cells[row, 13].Value != null)
                                    {
                                        var moduleCode = worksheet.Cells[row, 13].Value;
                                        if (moduleCode != null)
                                            tempModel.WednesdayModuleCodeId = moduleCodeList.SingleOrDefault(i => i.ModuleCodeName.ToUpper() == moduleCode.ToString().ToUpper()).ModuleCodeId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "WednesdayModuleCodeId"));
                                    }

                                    //  Wednesday Subject String
                                    if (worksheet.Cells[row, 14].Value != null)
                                    {
                                        var subjectString = worksheet.Cells[row, 14].Value;
                                        if (subjectString != null)
                                            tempModel.WednesdaySubjString = Convert.ToString(subjectString).ToUpper();
                                        else
                                            tempModel.WednesdaySubjString = String.Empty;
                                    }

                                    //  Thursday Module Code
                                    if (worksheet.Cells[row, 15].Value != null)
                                    {
                                        var moduleCode = worksheet.Cells[row, 15].Value;
                                        if (moduleCode != null)
                                            tempModel.ThursdayModuleCodeId = moduleCodeList.SingleOrDefault(i => i.ModuleCodeName.ToUpper() == moduleCode.ToString().ToUpper()).ModuleCodeId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "ThursdayModuleCodeId"));
                                    }

                                    //  Thursday Subject String
                                    if (worksheet.Cells[row, 16].Value != null)
                                    {
                                        var subjectString = worksheet.Cells[row, 16].Value;
                                        if (subjectString != null)
                                            tempModel.ThursdaySubjString = Convert.ToString(subjectString).ToUpper();
                                        else
                                            tempModel.ThursdaySubjString = String.Empty;
                                    }

                                    //  Friday Module Code
                                    if (worksheet.Cells[row, 17].Value != null)
                                    {
                                        var moduleCode = worksheet.Cells[row, 17].Value;
                                        if (moduleCode != null)
                                            tempModel.FridayModuleCodeId = moduleCodeList.SingleOrDefault(i => i.ModuleCodeName.ToUpper() == moduleCode.ToString().ToUpper()).ModuleCodeId;
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "FridayModuleCodeId"));
                                    }

                                    //  Friday Subject String
                                    if (worksheet.Cells[row, 18].Value != null)
                                    {
                                        var subjectString = worksheet.Cells[row, 18].Value;
                                        if (subjectString != null)
                                            tempModel.FridaySubjString = Convert.ToString(subjectString).ToUpper();
                                        else
                                            tempModel.FridaySubjString = String.Empty;
                                    }

                                    //  Extra01 Module Code
                                    if (worksheet.Cells[row, 19].Value != null)
                                    {
                                        var moduleCode = worksheet.Cells[row, 19].Value;
                                        if (moduleCode != null)
                                            tempModel.Extra1ModuleCodeId = moduleCodeList.SingleOrDefault(i => i.ModuleCodeName.ToUpper() == moduleCode.ToString().ToUpper()).ModuleCodeId;
                                        else
                                            tempModel.Extra1ModuleCodeId = null;
                                    }

                                    //  Extra01 Subject String
                                    if (worksheet.Cells[row, 20].Value != null)
                                    {
                                        var subjectString = worksheet.Cells[row, 20].Value;
                                        if (subjectString != null)
                                            tempModel.Extra1SubjString = Convert.ToString(subjectString).ToUpper();
                                        else
                                            tempModel.Extra1SubjString = String.Empty;
                                    }

                                    //  Extra02 Module Code
                                    if (worksheet.Cells[row, 21].Value != null)
                                    {
                                        var moduleCode = worksheet.Cells[row, 21].Value;
                                        if (moduleCode != null)
                                            tempModel.Extra2ModuleCodeId = moduleCodeList.SingleOrDefault(i => i.ModuleCodeName.ToUpper() == moduleCode.ToString().ToUpper()).ModuleCodeId;
                                        else
                                            tempModel.Extra2ModuleCodeId = null;
                                    }

                                    //  Extra02 Subject String
                                    if (worksheet.Cells[row, 22].Value != null)
                                    {
                                        var subjectString = worksheet.Cells[row, 22].Value;
                                        if (subjectString != null)
                                            tempModel.Extra2SubjString = Convert.ToString(subjectString).ToUpper();
                                        else
                                            tempModel.Extra2SubjString = String.Empty;
                                    }

                                    //  Extra03 Module Code
                                    if (worksheet.Cells[row, 23].Value != null)
                                    {
                                        var moduleCode = worksheet.Cells[row, 23].Value;
                                        if (moduleCode != null)
                                            tempModel.Extra3ModuleCodeId = moduleCodeList.SingleOrDefault(i => i.ModuleCodeName.ToUpper() == moduleCode.ToString().ToUpper()).ModuleCodeId;
                                        else
                                            tempModel.Extra3ModuleCodeId = null;
                                    }

                                    //  Extra03 Subject String
                                    if (worksheet.Cells[row, 24].Value != null)
                                    {
                                        var subjectString = worksheet.Cells[row, 24].Value;
                                        if (subjectString != null)
                                            tempModel.Extra3SubjString = Convert.ToString(subjectString).ToUpper();
                                        else
                                            tempModel.Extra3SubjString = String.Empty;
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
                                    //  add row to a error list (try-catch per row)
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
                return _context.Students.Any(i => i.QRCode.ToUpper() == tempModel.QRCode.ToUpper() && i.LastName.ToUpper() == tempModel.LastName.ToUpper() && !i.IsDeleted);
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

                    //  Monday
                    if (currModel.MondayModuleCodeId.ToString().ToUpper() != tempModel.MondayModuleCodeId.ToString().ToUpper())
                        totalUpdates++;
                    if (currModel.MondaySubjString.ToString().ToUpper() != tempModel.MondaySubjString.ToString().ToUpper())
                        totalUpdates++;

                    //  Tuesday
                    if (currModel.TuesdayModuleCodeId.ToString().ToUpper() != tempModel.TuesdayModuleCodeId.ToString().ToUpper())
                        totalUpdates++;
                    if (currModel.TuesdaySubjString.ToString().ToUpper() != tempModel.TuesdaySubjString.ToString().ToUpper())
                        totalUpdates++;

                    //  Wednesday
                    if (currModel.WednesdayModuleCodeId.ToString().ToUpper() != tempModel.WednesdayModuleCodeId.ToString().ToUpper())
                        totalUpdates++;
                    if (currModel.WednesdaySubjString.ToString().ToUpper() != tempModel.WednesdaySubjString.ToString().ToUpper())
                        totalUpdates++;

                    //  Thursday
                    if (currModel.ThursdayModuleCodeId.ToString().ToUpper() != tempModel.ThursdayModuleCodeId.ToString().ToUpper())
                        totalUpdates++;
                    if (currModel.ThursdaySubjString.ToString().ToUpper() != tempModel.ThursdaySubjString.ToString().ToUpper())
                        totalUpdates++;

                    //  Friday
                    if (currModel.FridayModuleCodeId.ToString().ToUpper() != tempModel.FridayModuleCodeId.ToString().ToUpper())
                        totalUpdates++;
                    if (currModel.FridaySubjString.ToString().ToUpper() != tempModel.FridaySubjString.ToString().ToUpper())
                        totalUpdates++;

                    //  Extra01
                    //  Extra02
                    //  Extra03
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
                model.ModuleList = _context.ModuleCodes.ToList().Count() < 0 ? new List<SelectListItem>() : _context.ModuleCodes.ToList().Select(i => new SelectListItem { Value = i.ModuleCodeId.ToString(), Text = i.ModuleCodeName }).OrderByDescending(i => i.Text);
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                model.GenderList = new List<SelectListItem>();
                model.ModuleList = new List<SelectListItem>();
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

        [Authorize]
        [HttpGet]
        public StudentModuleViewModel GetStudentTempModuleViewModel(String studentTempId)
        {
            try
            {
                var record = _context.StudentTemps.FirstOrDefault(i => !i.IsDeleted && i.StudentTempId.ToString().ToUpper() == studentTempId.ToUpper());    

                return new StudentModuleViewModel()
                {
                    MondayModuleCode = record.MondayModuleCodeId == null ? String.Empty : record.MondayModuleCode.ModuleCodeName,
                    MondaySubjectString = record.MondaySubjString,

                    TuesdayModuleCode = record.TuesdayModuleCodeId == null ? String.Empty : record.TuesdayModuleCode.ModuleCodeName,
                    TuesdaySubjectString = record.TuesdaySubjString,

                    WednesdayModuleCode = record.WednesdayModuleCodeId == null ? String.Empty : record.WednesdayModuleCode.ModuleCodeName,
                    WednesdaySubjectString = record.WednesdaySubjString,

                    ThursdayModuleCode = record.ThursdayModuleCodeId == null ? String.Empty : record.ThursdayModuleCode.ModuleCodeName,
                    ThursdaySubjectString = record.ThursdaySubjString,

                    FridayModuleCode = record.FridayModuleCodeId == null ? String.Empty : record.FridayModuleCode.ModuleCodeName,
                    FridaySubjectString = record.FridaySubjString,

                    Extra01ModuleCode = !record.Extra1ModuleCodeId.HasValue ? String.Empty : record.Extra1ModuleCode.ModuleCodeName,
                    Extra01SubjectString = record.Extra1SubjString,

                    Extra02ModuleCode = !record.Extra2ModuleCodeId.HasValue ? String.Empty : record.Extra2ModuleCode.ModuleCodeName,
                    Extra02SubjectString = record.Extra2SubjString,

                    Extra03ModuleCode = !record.Extra3ModuleCodeId.HasValue ? String.Empty : record.Extra3ModuleCode.ModuleCodeName,
                    Extra03SubjectString = record.Extra3SubjString,
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new StudentModuleViewModel();
            }
        }

        #endregion Utilities
    }
}