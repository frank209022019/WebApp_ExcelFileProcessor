using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WebApp_ExcelFileProcessor.Data;
using WebApp_ExcelFileProcessor.Models;
using WebApp_ExcelFileProcessor.ViewModels;

namespace WebApp_ExcelFileProcessor.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {
        private readonly ILogger<ReportController> _logger;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;
        private IHostEnvironment _hostEnvironment;

        public ReportController(ILogger<ReportController> logger, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, ApplicationDbContext context, IHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        #region Views

        [Authorize]
        public IActionResult SchoolAbsenteeByDate()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return RedirectToAction("Index", "Dashboard");
            }
        }

        [Authorize]
        public IActionResult StudentAbsenteeByDate()
        {
            try
            {
                var model = _context.Students.Where(i => !i.IsDeleted).Select(i => new SelectListItem() { Value = i.StudentId.ToString(), Text = String.Format(" [{0}] {1} {2}", i.StudentClass.DisplayName, i.FirstName, i.LastName) }).ToList();
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return RedirectToAction("Index", "Dashboard");
            }
        }

        #endregion Views

        #region Utilities

        [Authorize]
        [HttpGet]
        public String GenerateSchoolAbsenteeList(String gradeString, String classString, String groupValue, String startDateString, String endDateString)
        {
            try
            {
                String gradeClass = String.Format("{0}{1}", gradeString, classString);

                var studentScreeningsList = GetGradeScreenings(gradeClass.ToUpper(), groupValue.ToUpper(), Convert.ToDateTime(startDateString), Convert.ToDateTime(endDateString));
                if (studentScreeningsList.Count() <= 0)
                    throw new Exception("No student screening records found.");

                List<AbsenteeViewModel> returnList = new List<AbsenteeViewModel>();

                if (studentScreeningsList.Count() > 0)
                {
                    var studentList = _context.Students.Where(i => !i.IsDeleted &&
                                                                                                        i.StudentClass.DisplayName.ToUpper() == gradeClass.ToUpper() &&
                                                                                                        i.StudentGroup.DisplayName.ToUpper() == groupValue.ToUpper()).ToList();
                    var moduleRosterList = _context.GradeModuleRoster.Where(i => !i.IsDeleted && i.GradeInt == Convert.ToInt32(gradeString)).ToList();

                    //  Studens IN/NOT IN studentScreeningsList
                    //var studentsInScreeningList = studentList.Where(p => studentScreeningsList.Any(p2 => p2.StudentId == p.StudentId && !p.IsDeleted)).ToList();
                    //var studentsNotInScreeningList = studentList.Where(p => !studentScreeningsList.Any(p2 => p2.StudentId == p.StudentId && !p.IsDeleted)).ToList();

                    //   go through each student (studentsNotInScreeningList) : either absent or dont need to be at school
                    foreach (DateTime day in EachCalendarDay(Convert.ToDateTime(startDateString), Convert.ToDateTime(endDateString)))
                    {
                        //  STUDENTS IN - ALREADY HAVE SCREENING - PRESENT AT SCHOOL
                        //var studentsInScreeningList = studentList.Where(p => studentScreeningsList.Any(p2 => p2.StudentId == p.StudentId && !p.IsDeleted)).ToList();

                        //  STUDENTS NOT IN - ABSENT OR NO NEED TO BE AT SCHOOL
                        var studentsNotInScreeningList = studentList.Where(p => !studentScreeningsList.Any(p2 => p2.StudentId == p.StudentId && !p.IsDeleted &&
                                                                                                                                                                                                p2.ScreeningTimeStamp.Year == day.Year &&
                                                                                                                                                                                                p2.ScreeningTimeStamp.Month == day.Month &&
                                                                                                                                                                                                p2.ScreeningTimeStamp.Day == day.Day)).ToList();

                        if(studentsNotInScreeningList.Count() > 0)
                        {
                            foreach (var item in studentsNotInScreeningList)
                            {
                                var stud = studentList.FirstOrDefault(i => !i.IsDeleted && i.StudentId == item.StudentId);

                                switch (day.DayOfWeek)
                                {
                                    case DayOfWeek.Monday:
                                        Guid mondayModuleCodeId = moduleRosterList.FirstOrDefault(i => i.DayOfWeek == DayOfWeek.Monday).ModuleCodeId;
                                        if (mondayModuleCodeId == stud.MondayModuleCodeId)
                                            returnList.Add(new AbsenteeViewModel() { AbsentDateTime = day, StudentId = stud.StudentId });
                                        break;

                                    case DayOfWeek.Tuesday:
                                        Guid tuesdayModuleCodeId = moduleRosterList.FirstOrDefault(i => i.DayOfWeek == DayOfWeek.Tuesday).ModuleCodeId;
                                        if (tuesdayModuleCodeId == stud.TuesdayModuleCodeId)
                                            returnList.Add(new AbsenteeViewModel() { AbsentDateTime = day, StudentId = stud.StudentId });
                                        break;

                                    case DayOfWeek.Wednesday:
                                        Guid wednesdayModuleCodeId = moduleRosterList.FirstOrDefault(i => i.DayOfWeek == DayOfWeek.Wednesday).ModuleCodeId;
                                        if (wednesdayModuleCodeId == stud.WednesdayModuleCodeId)
                                            returnList.Add(new AbsenteeViewModel() { AbsentDateTime = day, StudentId = stud.StudentId });
                                        break;

                                    case DayOfWeek.Thursday:
                                        Guid thursdayModuleCodeId = moduleRosterList.FirstOrDefault(i => i.DayOfWeek == DayOfWeek.Thursday).ModuleCodeId;
                                        if (thursdayModuleCodeId == stud.ThursdayModuleCodeId)
                                            returnList.Add(new AbsenteeViewModel() { AbsentDateTime = day, StudentId = stud.StudentId });
                                        break;

                                    case DayOfWeek.Friday:
                                        Guid fridayModuleCodeId = moduleRosterList.FirstOrDefault(i => i.DayOfWeek == DayOfWeek.Friday).ModuleCodeId;
                                        if (fridayModuleCodeId == stud.FridayModuleCodeId)
                                            returnList.Add(new AbsenteeViewModel() { AbsentDateTime = day, StudentId = stud.StudentId });
                                        break;
                                }
                            }
                        }
                    }
                }
                //  Generate report - can be downloaded
                String reportGeneratedString = GenerateExcelReport(returnList, Convert.ToDateTime(startDateString).ToString("dd-MM-yyyy"), Convert.ToDateTime(endDateString).ToString("dd-MM-yyyy"));

                if (reportGeneratedString == null)
                    throw new Exception("Error occurred while genereating report.");

                return reportGeneratedString;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }

        [Authorize]
        [HttpGet]
        public String GenerateStudentAbsenteeList(String studentId, String startDateString, String endDateString)
        {
            try
            {
                var currentStudent = _context.Students.FirstOrDefault(i => !i.IsDeleted && i.StudentId == Guid.Parse(studentId));
                var studentScreenings = GetStudentScreenings(currentStudent, Convert.ToDateTime(startDateString), Convert.ToDateTime(endDateString));

                if (studentScreenings.Count() <= 0)
                    throw new Exception("No student screening records found.");

                List<AbsenteeViewModel> returnList = new List<AbsenteeViewModel>();

                if (studentScreenings.Count() > 0)
                {
                    var moduleRosterList = _context.GradeModuleRoster.Where(i => !i.IsDeleted && i.GradeInt == Convert.ToInt32(currentStudent.StudentClass.GradeInt)).ToList();

                    foreach (DateTime day in EachCalendarDay(Convert.ToDateTime(startDateString), Convert.ToDateTime(endDateString)))
                    {
                        //  check if no screening record exists for the student on this day
                        if (!CheckIfStudentHasScreeningForDateTime(day, studentScreenings, currentStudent.StudentId))
                        {
                            switch (day.DayOfWeek)
                            {
                                case DayOfWeek.Monday:
                                    Guid mondayModuleCodeId = moduleRosterList.FirstOrDefault(i => i.DayOfWeek == DayOfWeek.Monday).ModuleCodeId;
                                    if (mondayModuleCodeId == currentStudent.MondayModuleCodeId)
                                        returnList.Add(new AbsenteeViewModel() { AbsentDateTime = day, StudentId = currentStudent.StudentId });
                                    break;

                                case DayOfWeek.Tuesday:
                                    Guid tuesdayModuleCodeId = moduleRosterList.FirstOrDefault(i => i.DayOfWeek == DayOfWeek.Tuesday).ModuleCodeId;
                                    if (tuesdayModuleCodeId == currentStudent.TuesdayModuleCodeId)
                                        returnList.Add(new AbsenteeViewModel() { AbsentDateTime = day, StudentId = currentStudent.StudentId });
                                    break;

                                case DayOfWeek.Wednesday:
                                    Guid wednesdayModuleCodeId = moduleRosterList.FirstOrDefault(i => i.DayOfWeek == DayOfWeek.Wednesday).ModuleCodeId;
                                    if (wednesdayModuleCodeId == currentStudent.WednesdayModuleCodeId)
                                        returnList.Add(new AbsenteeViewModel() { AbsentDateTime = day, StudentId = currentStudent.StudentId });
                                    break;

                                case DayOfWeek.Thursday:
                                    Guid thursdayModuleCodeId = moduleRosterList.FirstOrDefault(i => i.DayOfWeek == DayOfWeek.Thursday).ModuleCodeId;
                                    if (thursdayModuleCodeId == currentStudent.ThursdayModuleCodeId)
                                        returnList.Add(new AbsenteeViewModel() { AbsentDateTime = day, StudentId = currentStudent.StudentId });
                                    break;

                                case DayOfWeek.Friday:
                                    Guid fridayModuleCodeId = moduleRosterList.FirstOrDefault(i => i.DayOfWeek == DayOfWeek.Friday).ModuleCodeId;
                                    if (fridayModuleCodeId == currentStudent.FridayModuleCodeId)
                                        returnList.Add(new AbsenteeViewModel() { AbsentDateTime = day, StudentId = currentStudent.StudentId });
                                    break;
                            }
                        }
                    }
                }
                //  Generate report - can be downloaded
                String reportGeneratedString = GenerateExcelReport(returnList, Convert.ToDateTime(startDateString).ToString("dd-MM-yyyy"), Convert.ToDateTime(endDateString).ToString("dd-MM-yyyy"));

                if (reportGeneratedString == null)
                    throw new Exception("Error occurred while genereating report.");

                return reportGeneratedString;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }

        [Authorize]
        private List<StudentScreening> GetGradeScreenings(String gradeClass, String groupName, DateTime startDate, DateTime endDate)
        {
            try
            {
                var returnList = _context.StudentScreenings.Where(i => !i.IsDeleted &&
                                                                                                                    i.Student.StudentClass.DisplayName.ToUpper() == gradeClass.ToUpper() &&
                                                                                                                    i.Student.StudentGroup.DisplayName.ToUpper() == groupName.ToUpper() &&
                                                                                                                    (i.ScreeningTimeStamp.Year >= startDate.Year && i.ScreeningTimeStamp.Year <= endDate.Year) &&
                                                                                                                    (i.ScreeningTimeStamp.Month >= startDate.Month && i.ScreeningTimeStamp.Month <= endDate.Month) &&
                                                                                                                    (i.ScreeningTimeStamp.Day >= startDate.Day && i.ScreeningTimeStamp.Day <= endDate.Day)).ToList();
                if (returnList.Count() == 0)
                    return new List<StudentScreening>();

                return returnList;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<StudentScreening>();
            }
        }

        [Authorize]
        private List<StudentScreening> GetStudentScreenings(Student student, DateTime startDate, DateTime endDate)
        {
            try
            {
                var returnList = _context.StudentScreenings.Where(i => !i.IsDeleted &&
                                                                                                                    i.Student.StudentClass.DisplayName.ToUpper() == student.StudentClass.DisplayName.ToUpper() &&
                                                                                                                    i.Student.StudentGroup.DisplayName.ToUpper() == student.StudentGroup.DisplayName.ToUpper() &&
                                                                                                                    (i.ScreeningTimeStamp.Year >= startDate.Year && i.ScreeningTimeStamp.Year <= endDate.Year) &&
                                                                                                                    (i.ScreeningTimeStamp.Month >= startDate.Month && i.ScreeningTimeStamp.Month <= endDate.Month) &&
                                                                                                                    (i.ScreeningTimeStamp.Day >= startDate.Day && i.ScreeningTimeStamp.Day <= endDate.Day)).ToList();
                if (returnList.Count() == 0)
                    return new List<StudentScreening>();

                return returnList;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<StudentScreening>();
            }
        }

        [Authorize]
        private IEnumerable<DateTime> EachCalendarDay(DateTime startDate, DateTime endDate)
        {
            for (var date = startDate.Date; date.Date <= endDate.Date; date = date.AddDays(1)) yield
            return date;
        }

        [Authorize]
        private String GenerateStudentFullNameWithClass(Student student)
        {
            try
            {
                return String.Format(" [{0}] {1} {2}", student.StudentClass.DisplayName, student.FirstName, student.LastName);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return String.Empty;
            }
        }

        [Authorize]
        private Boolean CheckIfStudentHasScreeningForDateTime(DateTime dtOne, List<StudentScreening> studScreenList, Guid studentId)
        {
            try
            {
                return studScreenList.Any(i => !i.IsDeleted &&
                                                                            i.ScreeningTimeStamp.Year == dtOne.Year &&
                                                                            i.ScreeningTimeStamp.Month == dtOne.Month &&
                                                                            i.ScreeningTimeStamp.Day == dtOne.Day &&
                                                                            i.StudentId == studentId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }
        }

        [Authorize]
        [HttpGet]
        public DateRangeViewModel GetMinMaxDateRange()
        {
            try
            {
                var screeningList = _context.StudentScreenings.Where(i => !i.IsDeleted).ToList();
                if (screeningList.Count() == 0)
                    throw new Exception("No student screening records found.");

                DateRangeViewModel model = new DateRangeViewModel()
                {
                    MinDateTime = screeningList.Select(i => i.ScreeningTimeStamp).Min(),
                    MaxDateTime = screeningList.Select(i => i.ScreeningTimeStamp).Max()
                };
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new DateRangeViewModel() { MinDateTime = DateTime.Now, MaxDateTime = DateTime.Now };
            }
        }

        [Authorize]
        private String GenerateExcelReport(List<AbsenteeViewModel> absentList, String startDate, String endDate)
        {
            try
            {
                List<Student> studentList = _context.Students.Where(i => !i.IsDeleted).ToList();
                List<Guid> distinctStudentIdList = absentList.Select(i => i.StudentId).Distinct().ToList();
                ExcelDownload model;

                //  New file name
                String fileName = String.Format("AbsenteeReport {0} - {1} - {2}.xlsx", startDate, endDate, Guid.NewGuid().ToString());

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage())
                {
                    //  Overview Worksheet
                    ExcelWorksheet wsSheet1 = package.Workbook.Worksheets.Add("Absent Records");
                    wsSheet1 = BuildAbsentHeaders(wsSheet1, startDate, endDate);
                    Int32 row = 3;
                    foreach (var item in absentList)
                    {
                        var temp = studentList.FirstOrDefault(x => x.StudentId == item.StudentId);
                        wsSheet1.Cells[row, 1].Value = item.AbsentDateTime.ToString("dd-MM-yyyy");
                        wsSheet1.Cells[row, 2].Value = temp.QRCode;
                        wsSheet1.Cells[row, 3].Value = temp.FirstName;
                        wsSheet1.Cells[row, 4].Value = temp.LastName;
                        wsSheet1.Cells[row, 5].Value = temp.StudentClass.DisplayName;
                        wsSheet1.Cells[row, 6].Value = temp.StudentGroup.DisplayName;
                        row++;
                    }

                    //  Summary Worksheet
                    ExcelWorksheet wsSheet2 = package.Workbook.Worksheets.Add("Absent Summary");
                    wsSheet2 = BuildAbsentSummaryHeaders(wsSheet2, startDate, endDate);
                    row = 3;
                    foreach (var item in distinctStudentIdList)
                    {
                        var temp = studentList.FirstOrDefault(x => x.StudentId == item);
                        wsSheet2.Cells[row, 1].Value = temp.QRCode;
                        wsSheet2.Cells[row, 2].Value = temp.FirstName;
                        wsSheet2.Cells[row, 3].Value = temp.LastName;
                        wsSheet2.Cells[row, 4].Value = temp.StudentClass.DisplayName;
                        wsSheet2.Cells[row, 5].Value = temp.StudentGroup.DisplayName;
                        wsSheet2.Cells[row, 6].Value = absentList.Where(i => i.StudentId == temp.StudentId).Count();
                        row++;
                    }

                    //  Worksheet settings
                    wsSheet1.Protection.IsProtected = false;
                    wsSheet1.Protection.AllowSelectLockedCells = false;
                    wsSheet2.Protection.IsProtected = false;
                    wsSheet2.Protection.AllowSelectLockedCells = false;

                    //  Save to database
                    model = new ExcelDownload()
                    {
                        DateCreated = DateTime.Now,
                        IsDeleted = false,
                        FileName = fileName
                    };
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        package.SaveAs(memoryStream);
                        memoryStream.Position = 0;
                        model.FileByteArray = memoryStream.ToArray();
                    }
                    _context.ExcelDownloads.Add(model);
                    _context.SaveChanges();
                }
                return model.ExcelDownloadId.ToString();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }

        [Authorize]
        private ExcelWorksheet BuildAbsentHeaders(ExcelWorksheet ws, String startDate, String endDate)
        {
            //  Header
            ws.Cells["A1:F1"].Merge = true;
            ws.Cells["A1:F1"].Style.Font.Bold = true;
            ws.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Cells["A1"].Value = String.Format("Absent Records {0} - {1}", startDate, endDate);

            //  Column names
            ws.Cells[1, 1, 1, 6].Style.Font.Bold = true;
            ws.Cells[2, 1, 2, 6].Style.Font.Bold = true;
            ws.Cells["A2"].Value = "Absent Date";
            ws.Cells["B2"].Value = "QR Code";
            ws.Cells["C2"].Value = "First Name";
            ws.Cells["D2"].Value = "Last Name";
            ws.Cells["E2"].Value = "Grade/Class";
            ws.Cells["F2"].Value = "Group";
            return ws;
        }

        [Authorize]
        private ExcelWorksheet BuildAbsentSummaryHeaders(ExcelWorksheet ws, String startDate, String endDate)
        {
            //  Header
            ws.Cells["A1:F1"].Merge = true;
            ws.Cells["A1:F1"].Style.Font.Bold = true;
            ws.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Cells["A1"].Value = String.Format("Absent Summary {0} - {1}", startDate, endDate);

            //  Column names
            ws.Cells[1, 1, 1, 6].Style.Font.Bold = true;
            ws.Cells[2, 1, 2, 6].Style.Font.Bold = true;
            ws.Cells["A2"].Value = "QR Code";
            ws.Cells["B2"].Value = "First Name";
            ws.Cells["C2"].Value = "Last Name";
            ws.Cells["D2"].Value = "Grade/Class";
            ws.Cells["E2"].Value = "Group";
            ws.Cells["F2"].Value = "Total Absent Days";

            return ws;
        }

        [Authorize]
        [HttpGet]
        public ActionResult ExportAbsenteeReport(String fileGuid)
        {
            try
            {
                if (fileGuid != null && fileGuid != String.Empty)
                {
                    var fileRecord = _context.ExcelDownloads.FirstOrDefault(i => i.ExcelDownloadId == Guid.Parse(fileGuid));
                    fileRecord.IsDeleted = true;
                    _context.SaveChanges();

                    return File(fileRecord.FileByteArray, "application/vnd.ms-excel", fileRecord.FileName);
                }
                else
                {
                    throw new Exception("Invalid report parameter used.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest("Could not download report");
            }
        }

        #endregion Utilities
    }
}