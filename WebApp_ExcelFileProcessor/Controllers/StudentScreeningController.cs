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
    public class StudentScreeningController : Controller
    {
        private readonly ILogger<StudentScreeningController> _logger;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public StudentScreeningController(ILogger<StudentScreeningController> logger, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        #region Views

        [Authorize]
        public IActionResult UploadStudentScreening()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UploadStudentScreening(List<IFormFile> files)
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
                var processResult = await ProcessStudentScreenUpload(files.FirstOrDefault());
                if (!processResult.ResponseValid)
                    throw new Exception(processResult.ResponseMessage);

                return Ok(new { success = true, message = "All files uploaded successfully!", result = model });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(new { success = false, message = ex.Message });
            }
        }

        [Authorize]
        public IActionResult ManageStudentScreening()
        {
            try
            {
                var currentScreenings = _context.StudentScreenings.Where(i => !i.IsDeleted).ToList();
                if (currentScreenings.Count() == 0)
                    throw new Exception("No student screening records found.");

                return View(currentScreenings);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View(new List<StudentScreening>());
            }
        }

        [Authorize]
        public IActionResult UploadStudentScreeningResult()
        {
            try
            {
                UploadStudentScreeningResultViewModel model = new UploadStudentScreeningResultViewModel();

                var tempResults = _context.StudentScreeningTemps.ToList();
                if (tempResults.Count() > 0)
                {
                    var createTemp = tempResults.Where(i => i.RowType == 'C').ToList();
                    if (createTemp != null && createTemp.Count() > 0)
                        model.CreateList = createTemp;
                    else
                        model.CreateList = new List<StudentScreeningTemp>();

                    var existTemp = tempResults.Where(i => i.RowType == 'X').ToList();
                    if (existTemp != null && existTemp.Count() > 0)
                        model.ExisitingList = existTemp;
                    else
                        model.ExisitingList = new List<StudentScreeningTemp>();

                    var errorTemp = tempResults.Where(i => i.RowType == 'E').ToList();
                    if (errorTemp != null && errorTemp.Count() > 0)
                        model.ErrorList = errorTemp;
                    else
                        model.ErrorList = new List<StudentScreeningTemp>();

                    return View(model);
                }
                else
                {
                    return RedirectToAction("UploadStudentScreening", "StudentScreening");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return RedirectToAction("UploadStudentScreening", "StudentScreening");
            }
        }

        [Authorize]
        public IActionResult AddScreening()
        {
            StudentScreening model = new StudentScreening()
            {
                ScrenningTimeStamp = DateTime.Now,
                IsDeleted = false,
                DateCreated = DateTime.Now
            };
            model.StudentList = _context.Students.ToList().Select(i => new SelectListItem()
            {
                Value = i.StudentId.ToString(),
                Text = i.FirstName + " " + i.LastName

            }).ToList();
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddScreening(StudentScreening model)
        {
            try
            {
                var exisitingStudent = _context.Students.FirstOrDefault(i => i.StudentId == model.StudentId && !i.IsDeleted);
                StudentScreening newModel = new StudentScreening()
                {
                    
                    QRCodeId = model.QRCodeId,
                    Temp = model.Temp,
                    GeneralSenseWellbeing = model.GeneralSenseWellbeing,
                    WearingAMask = model.WearingAMask,
                    HighRiskTravel14Days = model.HighRiskTravel14Days,
                    CloseContactInfectedPerson = model.CloseContactInfectedPerson,
                    CloseContactProbableInfectedPerson = model.CloseContactProbableInfectedPerson,
                    AttendHealthFacility14Days = model.AttendHealthFacility14Days,
                    AdmittedSeverPneumonia = model.AdmittedSeverPneumonia,
                    SufferFromChronicDisease = model.SufferFromChronicDisease,
                    AnyOfTheFollowingSymptoms = model.AnyOfTheFollowingSymptoms,
                    ScrenningTimeStamp = model.ScrenningTimeStamp,
                    StudentDisplayName = exisitingStudent.FirstName + " " + exisitingStudent.LastName,
                    StudentId = exisitingStudent.StudentId,
                    IsDeleted = false,
                    DateCreated = DateTime.Now
                };
                _context.StudentScreenings.Add(newModel);
                _context.SaveChanges();
                
                return RedirectToAction("ManageStudentScreening");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return RedirectToAction("ManageStudentScreening");
            }
        }

        [Authorize]
        public IActionResult UpdateScreening(String ScreeningId)
        {
            try
            {
                var model = _context.StudentScreenings.SingleOrDefault(i => i.StudentScreeningId.ToString().ToUpper() == ScreeningId.ToUpper());
                if (model != null)
                {
                    var student = _context.Students.FirstOrDefault(i => i.StudentId == model.StudentId && !i.IsDeleted);
                    model.StudentDisplayName = student.FirstName + " " + student.LastName;
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
        public IActionResult UpdateScreening(StudentScreening model)
        {
            try
            {
                var currModel = _context.StudentScreenings.SingleOrDefault(i => i.StudentScreeningId == model.StudentScreeningId);
                currModel.QRCodeId = model.QRCodeId;
                currModel.Temp = model.Temp;
                currModel.GeneralSenseWellbeing = model.GeneralSenseWellbeing;
                currModel.WearingAMask = model.WearingAMask;
                currModel.HighRiskTravel14Days = model.HighRiskTravel14Days;
                currModel.CloseContactInfectedPerson = model.CloseContactInfectedPerson;
                currModel.CloseContactProbableInfectedPerson = model.CloseContactProbableInfectedPerson;
                currModel.AttendHealthFacility14Days = model.AttendHealthFacility14Days;
                currModel.AdmittedSeverPneumonia = model.AdmittedSeverPneumonia;
                currModel.SufferFromChronicDisease = model.SufferFromChronicDisease;
                currModel.AnyOfTheFollowingSymptoms = model.AnyOfTheFollowingSymptoms;
                currModel.ScrenningTimeStamp = model.ScrenningTimeStamp;
                _context.StudentScreenings.Update(currModel);
                _context.SaveChanges();

                return RedirectToAction("ManageStudentScreening");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return RedirectToAction("ManageStudentScreening");
            }
        }

        [Authorize]
        public IActionResult DeleteScreening(String ScreeningId)
        {
            try
            {
                var model = _context.StudentScreenings.SingleOrDefault(i => i.StudentScreeningId.ToString().ToUpper() == ScreeningId.ToUpper());
                if (model != null)
                {
                    var student = _context.Students.FirstOrDefault(i => i.StudentId == model.StudentId && !i.IsDeleted);
                    model.StudentDisplayName = student.FirstName + " " + student.LastName;
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
        public IActionResult DeleteScreening(StudentScreening model)
        {
            try
            {
                var currModel = _context.StudentScreenings.SingleOrDefault(i => i.StudentScreeningId == model.StudentScreeningId && !i.IsDeleted);
                currModel.IsDeleted = true;
                _context.StudentScreenings.Update(currModel);
                _context.SaveChanges();

                return RedirectToAction("ManageStudentScreening");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return RedirectToAction("ManageStudentScreening");
            }
        }

        [Authorize]
        public IActionResult ViewScreening(String ScreeningId)
        {
            try
            {
                var model = _context.StudentScreenings.SingleOrDefault(i => i.StudentScreeningId.ToString().ToUpper() == ScreeningId.ToUpper());

                if (model != null)
                {
                    var student = _context.Students.FirstOrDefault(i => i.StudentId == model.StudentId && !i.IsDeleted);
                    model.StudentDisplayName = student.FirstName + " " + student.LastName;
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

        #endregion Views

        #region Utilities

        [Authorize]
        private async Task<UploadStudentScreenProcessViewModel> ProcessStudentScreenUpload(IFormFile file)
        {
            try
            {
                //  Validate Template
                var validTemplate = await ValidateStudentScreenTemplate(file);
                if (!validTemplate)
                    throw new Exception("Invalid template used.");

                //  Clear all temp records
                var currentTempList = _context.StudentScreeningTemps.ToList();
                if (currentTempList.Count() > 0)
                {
                    _context.StudentScreeningTemps.RemoveRange(currentTempList);
                    _context.SaveChanges();
                }

                //  Lists for result view
                UploadStudentScreenProcessViewModel returnValue = new UploadStudentScreenProcessViewModel()
                {
                    ResponseId = null,
                    ResponseValid = true,
                    ResponseDateTime = DateTime.Now,
                    ResponseMessage = "File processing successful.",
                    NewScreeningList = new List<Models.StudentScreeningTemp>(),
                    ErrorScreeningList = new List<Models.StudentScreeningTemp>(),
                    ExisitingScreeningList = new List<Models.StudentScreeningTemp>()
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
                            for (int row = 2; row < rowCount; row++)
                            {
                                //  StudentScreenTemp
                                Boolean rowHasError = false;
                                StudentScreeningTemp tempModel = new StudentScreeningTemp()
                                {
                                    RowNumber = row,
                                    IsDeleted = false,
                                    DateCreated = DateTime.Now
                                };

                                try
                                {
                                    //  Col1        ID    **
                                    //  Col2        Temp        **
                                    //  Col3       General sense of wellbeing?
                                    //  Col4        Wearing a mask?
                                    //  Col5        Have you travelled to a high-risk area in the last 14 days?
                                    //  Col6        Have you recently been in close contact with someone infected with the virus?
                                    //  Col7        Have you recently been in contact with someone probable to be infected with the virus?
                                    //  Col8        Have you attended a health facility where patients that have the virus are treated in the last 14 days?
                                    //  Col9        Have you been admitted with severe pneumonia
                                    //  Col10        Do you suffer from any chronic disease?
                                    //  Col11       Do you have any of the following symptoms?      **
                                    //  Col12       Timestamp       **

                                    //  Check if current rows columns have null values
                                    for (int col = 1; col <= 12; col++)
                                    {
                                        if (worksheet.Cells[row, col].Value == null)
                                            rowHasError = true;
                                    }

                                    //  QRCodeId
                                    if (worksheet.Cells[row, 1].Value != null)
                                    {
                                        var cellValue = worksheet.Cells[row, 1].Value;
                                        if (cellValue != null)
                                            tempModel.QRCodeId = cellValue.ToString();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {1}", row, "StudentColor"));

                                        //  Get StudentId for record
                                        var getStudentId = _context.Students.FirstOrDefault(i => i.QRCode.ToUpper() == tempModel.QRCodeId.ToUpper() && !i.IsDeleted).StudentId;
                                        if (getStudentId == Guid.Empty)
                                            rowHasError = true;
                                        else
                                            tempModel.StudentId = getStudentId;
                                    }

                                    //  Temp
                                    if (worksheet.Cells[row, 2].Value != null)
                                    {
                                        var cellValue = worksheet.Cells[row, 2].Value;
                                        if (cellValue != null)
                                            tempModel.Temp = cellValue.ToString();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {2}", row, "StudentColor"));
                                    }

                                    //  GeneralSenseWellbeing
                                    if (worksheet.Cells[row, 3].Value != null)
                                    {
                                        var cellValue = worksheet.Cells[row, 3].Value;
                                        if (cellValue != null)
                                            tempModel.GeneralSenseWellbeing = cellValue.ToString();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {3}", row, "StudentColor"));
                                    }

                                    //  WearingAMask
                                    if (worksheet.Cells[row, 4].Value != null)
                                    {
                                        var cellValue = worksheet.Cells[row, 4].Value;
                                        if (cellValue != null)
                                            tempModel.WearingAMask = cellValue.ToString();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {4}", row, "StudentColor"));
                                    }

                                    //  HighRiskTravel14Days
                                    if (worksheet.Cells[row, 5].Value != null)
                                    {
                                        var cellValue = worksheet.Cells[row, 5].Value;
                                        if (cellValue != null)
                                            tempModel.HighRiskTravel14Days = cellValue.ToString();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {5}", row, "StudentColor"));
                                    }

                                    //  CloseContactInfectedPerson
                                    if (worksheet.Cells[row, 6].Value != null)
                                    {
                                        var cellValue = worksheet.Cells[row, 6].Value;
                                        if (cellValue != null)
                                            tempModel.CloseContactInfectedPerson = cellValue.ToString();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {6}", row, "StudentColor"));
                                    }

                                    //  CloseContactProbableInfectedPerson
                                    if (worksheet.Cells[row, 7].Value != null)
                                    {
                                        var cellValue = worksheet.Cells[row, 7].Value;
                                        if (cellValue != null)
                                            tempModel.CloseContactProbableInfectedPerson = cellValue.ToString();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {7}", row, "StudentColor"));
                                    }

                                    //  AttendHealthFacility14Days
                                    if (worksheet.Cells[row, 8].Value != null)
                                    {
                                        var cellValue = worksheet.Cells[row, 8].Value;
                                        if (cellValue != null)
                                            tempModel.AttendHealthFacility14Days = cellValue.ToString();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {8}", row, "StudentColor"));
                                    }

                                    //  AdmittedSeverPneumonia
                                    if (worksheet.Cells[row, 9].Value != null)
                                    {
                                        var cellValue = worksheet.Cells[row, 9].Value;
                                        if (cellValue != null)
                                            tempModel.AdmittedSeverPneumonia = cellValue.ToString();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {9}", row, "StudentColor"));
                                    }

                                    //  SufferFromChronicDisease
                                    if (worksheet.Cells[row, 10].Value != null)
                                    {
                                        var cellValue = worksheet.Cells[row, 10].Value;
                                        if (cellValue != null)
                                            tempModel.SufferFromChronicDisease = cellValue.ToString();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {10}", row, "StudentColor"));
                                    }

                                    //  AnyOfTheFollowingSymptoms
                                    if (worksheet.Cells[row, 11].Value != null)
                                    {
                                        var cellValue = worksheet.Cells[row, 11].Value;
                                        if (cellValue != null)
                                            tempModel.AnyOfTheFollowingSymptoms = cellValue.ToString();
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {11}", row, "StudentColor"));
                                    }

                                    //  ScrenningTimeStamp
                                    if (worksheet.Cells[row, 12].Value != null)
                                    {
                                        var cellValue = worksheet.Cells[row, 12].Value;
                                        if (cellValue != null)
                                            tempModel.ScrenningTimeStamp = Convert.ToDateTime(cellValue.ToString());
                                        else
                                            throw new Exception(String.Format("ROW: {0} COL: {12}", row, "StudentColor"));
                                    }

                                    if (!rowHasError)
                                    {
                                        //  Check if screening already exisits
                                        var alreadyExists = CheckIfScreeningExists(tempModel);
                                        if (alreadyExists)
                                        {
                                            tempModel.RowType = 'X';
                                            returnValue.ExisitingScreeningList.Add(tempModel);
                                        }
                                        else
                                        {
                                            tempModel.RowType = 'C';
                                            returnValue.NewScreeningList.Add(tempModel);
                                        }
                                    }
                                    else
                                    {
                                        tempModel.RowType = 'E';
                                        returnValue.ErrorScreeningList.Add(tempModel);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    _logger.LogError(ex.Message);
                                    tempModel.RowType = 'E';
                                    returnValue.ErrorScreeningList.Add(tempModel);
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
                if (returnValue.NewScreeningList.Count() > 0)
                {
                    _context.StudentScreeningTemps.AddRange(returnValue.NewScreeningList);
                    _context.SaveChanges();
                }
                if (returnValue.ExisitingScreeningList.Count() > 0)
                {
                    _context.StudentScreeningTemps.AddRange(returnValue.ExisitingScreeningList);
                    _context.SaveChanges();
                }
                if (returnValue.ErrorScreeningList.Count() > 0)
                {
                    _context.StudentScreeningTemps.AddRange(returnValue.ErrorScreeningList);
                    _context.SaveChanges();
                }

                return returnValue;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new UploadStudentScreenProcessViewModel() { ResponseId = null, ResponseValid = false, ResponseDateTime = DateTime.Now, ResponseMessage = ex.Message, NewScreeningList = new List<Models.StudentScreeningTemp>(), ErrorScreeningList = new List<Models.StudentScreeningTemp>(), ExisitingScreeningList = new List<Models.StudentScreeningTemp>() };
            }
        }

        [Authorize]
        private async Task<Boolean> ValidateStudentScreenTemplate(IFormFile file)
        {
            try
            {
                //  A1 = id
                //  B1 = temp
                //  C1 = General sense of wellbeing?

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

                        var validateNr = worksheet.Cells[1, 1].Value;
                        if (validateNr == null || validateNr.ToString().ToLower() != "id")
                            throw new Exception("Invalid template used");

                        var validateSurname = worksheet.Cells[1, 2].Value;
                        if (validateSurname == null || validateSurname.ToString().ToLower() != "temp")
                            throw new Exception("Invalid template used");

                        var validateName = worksheet.Cells[1, 3].Value;
                        if (validateName == null || validateName.ToString().ToLower() != "general sense of wellbeing?")
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
        private Boolean CheckIfScreeningExists(StudentScreeningTemp model)
        {
            try
            {
                DateTime validDT = Convert.ToDateTime(model.ScrenningTimeStamp);
                return _context.StudentScreenings.Any(i => i.QRCodeId.ToUpper() == model.QRCodeId.ToUpper()
                                && i.ScrenningTimeStamp.Day == validDT.Day
                                && i.ScrenningTimeStamp.Month == validDT.Month
                                && i.ScrenningTimeStamp.Year == validDT.Year
                                && i.ScrenningTimeStamp.Hour == validDT.Hour
                                && i.ScrenningTimeStamp.Minute == validDT.Minute
                                && i.ScrenningTimeStamp.Second == validDT.Second
                                && !i.IsDeleted);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }
        }

        [Authorize]
        private String GetStudentDisplayName(Guid studentId)
        {
            try
            {
                var student = _context.Students.FirstOrDefault(x => x.StudentId == (Guid)studentId && !x.IsDeleted);
                return String.Format("{0} {1}", student.FirstName, student.LastName);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return String.Empty;
            }
        }

        [Authorize]
        [HttpGet]
        public List<StudentScreeningTempViewModel> GetCreateStudentScreeningList()
        {
            try
            {
                var tempResults = _context.StudentScreeningTemps.ToList();
                var returnList = tempResults.Where(i => i.RowType == 'C').ToList();
                if (returnList.Count() > 0)
                {
                    return returnList.Select(i => new StudentScreeningTempViewModel()
                    {
                        StudentScreeningTempId = i.StudentScreeningTempId.ToString(),
                        QRCodeId = i.QRCodeId == null ? String.Empty : i.QRCodeId,
                        Temp = i.QRCodeId == null ? String.Empty : i.Temp,
                        GeneralSenseWellbeing = i.QRCodeId == null ? String.Empty : i.GeneralSenseWellbeing,
                        WearingAMask = i.QRCodeId == null ? String.Empty : i.WearingAMask,
                        HighRiskTravel14Days = i.QRCodeId == null ? String.Empty : i.HighRiskTravel14Days,
                        CloseContactInfectedPerson = i.QRCodeId == null ? String.Empty : i.CloseContactInfectedPerson,
                        CloseContactProbableInfectedPerson = i.QRCodeId == null ? String.Empty : i.CloseContactProbableInfectedPerson,
                        AttendHealthFacility14Days = i.QRCodeId == null ? String.Empty : i.AttendHealthFacility14Days,
                        AdmittedSeverPneumonia = i.QRCodeId == null ? String.Empty : i.AdmittedSeverPneumonia,
                        SufferFromChronicDisease = i.QRCodeId == null ? String.Empty : i.SufferFromChronicDisease,
                        AnyOfTheFollowingSymptoms = i.QRCodeId == null ? String.Empty : i.AnyOfTheFollowingSymptoms,
                        ScreeningTimeStamp = i.QRCodeId == null ? String.Empty : i.ScrenningTimeStamp.ToString(),
                        RowNumber = i.QRCodeId == null ? String.Empty : i.RowNumber.ToString(),
                        StudentDisplayName = i.StudentId == null ? String.Empty : GetStudentDisplayName((Guid)i.StudentId),
                        StudentClass = i.StudentId == null ? String.Empty : _context.Students.FirstOrDefault(x => x.StudentId == (Guid)i.StudentId && !x.IsDeleted).StudentClass.DisplayName
                    }).ToList();
                }
                else
                {
                    return new List<StudentScreeningTempViewModel>();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<StudentScreeningTempViewModel>();
            }
        }

        [Authorize]
        [HttpGet]
        public List<StudentScreeningTempViewModel> GetExistingStudentScreeningList()
        {
            try
            {
                var tempResults = _context.StudentScreeningTemps.ToList();
                var returnList = tempResults.Where(i => i.RowType == 'X').ToList();
                if (returnList.Count() > 0)
                {
                    return returnList.Select(i => new StudentScreeningTempViewModel()
                    {
                        StudentScreeningTempId = i.StudentScreeningTempId.ToString(),
                        QRCodeId = i.QRCodeId == null ? String.Empty : i.QRCodeId,
                        Temp = i.QRCodeId == null ? String.Empty : i.Temp,
                        GeneralSenseWellbeing = i.QRCodeId == null ? String.Empty : i.GeneralSenseWellbeing,
                        WearingAMask = i.QRCodeId == null ? String.Empty : i.WearingAMask,
                        HighRiskTravel14Days = i.QRCodeId == null ? String.Empty : i.HighRiskTravel14Days,
                        CloseContactInfectedPerson = i.QRCodeId == null ? String.Empty : i.CloseContactInfectedPerson,
                        CloseContactProbableInfectedPerson = i.QRCodeId == null ? String.Empty : i.CloseContactProbableInfectedPerson,
                        AttendHealthFacility14Days = i.QRCodeId == null ? String.Empty : i.AttendHealthFacility14Days,
                        AdmittedSeverPneumonia = i.QRCodeId == null ? String.Empty : i.AdmittedSeverPneumonia,
                        SufferFromChronicDisease = i.QRCodeId == null ? String.Empty : i.SufferFromChronicDisease,
                        AnyOfTheFollowingSymptoms = i.QRCodeId == null ? String.Empty : i.AnyOfTheFollowingSymptoms,
                        ScreeningTimeStamp = i.QRCodeId == null ? String.Empty : i.ScrenningTimeStamp.ToString(),
                        RowNumber = i.QRCodeId == null ? String.Empty : i.RowNumber.ToString(),
                        StudentDisplayName = i.StudentId == null ? String.Empty : GetStudentDisplayName((Guid)i.StudentId),
                        StudentClass = i.StudentId == null ? String.Empty : _context.Students.FirstOrDefault(x => x.StudentId == (Guid)i.StudentId && !x.IsDeleted).StudentClass.DisplayName
                    }).ToList();
                }
                else
                {
                    return new List<StudentScreeningTempViewModel>();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<StudentScreeningTempViewModel>();
            }
        }

        [Authorize]
        [HttpGet]
        public List<StudentScreeningTempViewModel> GetErrorStudentScreeningList()
        {
            try
            {
                var tempResults = _context.StudentScreeningTemps.ToList();
                var returnList = tempResults.Where(i => i.RowType == 'E').ToList();
                if (returnList.Count() > 0)
                {
                    return returnList.Select(i => new StudentScreeningTempViewModel()
                    {
                        StudentScreeningTempId = i.StudentScreeningTempId.ToString(),
                        QRCodeId = i.QRCodeId == null ? String.Empty : i.QRCodeId,
                        Temp = i.QRCodeId == null ? String.Empty : i.Temp,
                        GeneralSenseWellbeing = i.QRCodeId == null ? String.Empty : i.GeneralSenseWellbeing,
                        WearingAMask = i.QRCodeId == null ? String.Empty : i.WearingAMask,
                        HighRiskTravel14Days = i.QRCodeId == null ? String.Empty : i.HighRiskTravel14Days,
                        CloseContactInfectedPerson = i.QRCodeId == null ? String.Empty : i.CloseContactInfectedPerson,
                        CloseContactProbableInfectedPerson = i.QRCodeId == null ? String.Empty : i.CloseContactProbableInfectedPerson,
                        AttendHealthFacility14Days = i.QRCodeId == null ? String.Empty : i.AttendHealthFacility14Days,
                        AdmittedSeverPneumonia = i.QRCodeId == null ? String.Empty : i.AdmittedSeverPneumonia,
                        SufferFromChronicDisease = i.QRCodeId == null ? String.Empty : i.SufferFromChronicDisease,
                        AnyOfTheFollowingSymptoms = i.QRCodeId == null ? String.Empty : i.AnyOfTheFollowingSymptoms,
                        ScreeningTimeStamp = i.QRCodeId == null ? String.Empty : i.ScrenningTimeStamp.ToString(),
                        RowNumber = i.QRCodeId == null ? String.Empty : i.RowNumber.ToString(),
                        StudentDisplayName = i.StudentId == null ? String.Empty : GetStudentDisplayName((Guid)i.StudentId),
                        StudentClass = i.StudentId == null ? String.Empty : _context.Students.FirstOrDefault(x => x.StudentId == (Guid)i.StudentId && !x.IsDeleted).StudentClass.DisplayName
                    }).ToList();
                }
                else
                {
                    return new List<StudentScreeningTempViewModel>();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<StudentScreeningTempViewModel>();
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult CompleteStudentScreeningUpload()
        {
            try
            {
                var tempList = _context.StudentScreeningTemps.ToList();
                if (tempList.Count() > 0)
                {
                    //  create new records
                    var createList = tempList.Where(i => i.RowType == 'C').ToList();
                    if (createList.Count() > 0)
                    {
                        List<StudentScreening> studentList = new List<StudentScreening>();
                        foreach (var item in createList)
                        {
                            studentList.Add(new StudentScreening()
                            {
                                QRCodeId = item.QRCodeId,
                                Temp = item.Temp,
                                GeneralSenseWellbeing = item.GeneralSenseWellbeing,
                                WearingAMask = item.WearingAMask,
                                HighRiskTravel14Days = item.HighRiskTravel14Days,
                                CloseContactInfectedPerson = item.CloseContactInfectedPerson,
                                CloseContactProbableInfectedPerson = item.CloseContactProbableInfectedPerson,
                                AttendHealthFacility14Days = item.AttendHealthFacility14Days,
                                AdmittedSeverPneumonia = item.AdmittedSeverPneumonia,
                                SufferFromChronicDisease = item.SufferFromChronicDisease,
                                AnyOfTheFollowingSymptoms = item.AnyOfTheFollowingSymptoms,
                                ScrenningTimeStamp = Convert.ToDateTime(item.ScrenningTimeStamp),
                                StudentId = (Guid)item.StudentId,
                                IsDeleted = false,
                                DateCreated = DateTime.Now
                            });
                        }
                        _context.StudentScreenings.AddRange(studentList);
                        _context.SaveChanges();
                    }
                }

                //  clear temp list
                _context.StudentScreeningTemps.RemoveRange(tempList);
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
        public List<StudentScreeningViewModel> GetStudentScreeningList()
        {
            try
            {
                var studentList = _context.StudentScreenings.Where(i => !i.IsDeleted).ToList();
                if (studentList.Count() == 0)
                    throw new Exception("No student screenings found.");
                return studentList.Select(i => new StudentScreeningViewModel()
                {
                    StudentScreeningId = i.StudentScreeningId.ToString(),
                    QRCodeId = i.QRCodeId == null ? String.Empty : i.QRCodeId,
                    Temp = i.QRCodeId == null ? String.Empty : i.Temp,
                    GeneralSenseWellbeing = i.QRCodeId == null ? String.Empty : i.GeneralSenseWellbeing,
                    WearingAMask = i.QRCodeId == null ? String.Empty : i.WearingAMask,
                    HighRiskTravel14Days = i.QRCodeId == null ? String.Empty : i.HighRiskTravel14Days,
                    CloseContactInfectedPerson = i.QRCodeId == null ? String.Empty : i.CloseContactInfectedPerson,
                    CloseContactProbableInfectedPerson = i.QRCodeId == null ? String.Empty : i.CloseContactProbableInfectedPerson,
                    AttendHealthFacility14Days = i.QRCodeId == null ? String.Empty : i.AttendHealthFacility14Days,
                    AdmittedSeverPneumonia = i.QRCodeId == null ? String.Empty : i.AdmittedSeverPneumonia,
                    SufferFromChronicDisease = i.QRCodeId == null ? String.Empty : i.SufferFromChronicDisease,
                    AnyOfTheFollowingSymptoms = i.QRCodeId == null ? String.Empty : i.AnyOfTheFollowingSymptoms,
                    ScreeningTimeStamp = i.QRCodeId == null ? String.Empty : i.ScrenningTimeStamp.ToString(),
                    StudentDisplayName = i.StudentId == Guid.Empty ? String.Empty : GetStudentDisplayName((Guid)i.StudentId),
                    StudentId = i.StudentId != Guid.Empty ? String.Empty : i.StudentId.ToString(),
                    StudentClass = i.StudentId == Guid.Empty ? String.Empty : _context.Students.FirstOrDefault(x => x.StudentId == (Guid)i.StudentId && !x.IsDeleted).StudentClass.DisplayName
                }).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<StudentScreeningViewModel>();
            }
        }

        [Authorize]
        [HttpGet]
        public StudentScreeningViewModel GetStudentDetail(String StudentId)
        {
            try
            {
                var student = _context.Students.FirstOrDefault(i => i.StudentId.ToString().ToUpper() == StudentId.ToUpper() && !i.IsDeleted);
                if (student == null)
                    throw new Exception("No student found.");
                return new StudentScreeningViewModel()
                {
                    QRCodeId = student.QRCode.ToUpper(),
                    StudentClass = student.StudentClass.DisplayName.ToUpper()      
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new StudentScreeningViewModel();
            }
        }

        [Authorize]
        [HttpDelete]
        public IActionResult DeleteStudentScreeningTempRecord(String screenTempId)
        {
            try
            {
                if (screenTempId == null)
                    return BadRequest("Invalid parameter.");
                var record = _context.StudentScreeningTemps.SingleOrDefault(i => i.StudentScreeningTempId.ToString().ToUpper() == screenTempId.ToUpper());
                if (record == null)
                    return BadRequest("Error occurred while trying to delete the record");
                _context.StudentScreeningTemps.Remove(record);
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