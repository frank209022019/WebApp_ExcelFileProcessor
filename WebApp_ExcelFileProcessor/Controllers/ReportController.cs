using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
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

        public ReportController(ILogger<ReportController> logger, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
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
        public List<AbsenteeViewModel> GenerateSchoolAbsenteeList(String gradeString, String startDateString, String endDateString)
        {
            try
            {
                var studentScreeningsList = GetGradeScreenings(Convert.ToInt32(gradeString), Convert.ToDateTime(startDateString), Convert.ToDateTime(endDateString));
                if (studentScreeningsList.Count() <= 0)
                    throw new Exception("No student screening records found.");

                List<AbsenteeViewModel> returnList = new List<AbsenteeViewModel>();

                if (studentScreeningsList.Count() > 0)
                {
                    var studentList = _context.Students.Where(i => !i.IsDeleted && i.StudentClass.GradeInt == Convert.ToInt32(gradeString)).ToList();
                    var moduleRosterList = _context.GradeModuleRoster.Where(i => !i.IsDeleted && i.GradeInt == Convert.ToInt32(gradeString)).ToList();

                    //  Studens IN/NOT IN studentScreeningsList
                    var studentsInScreeningList = studentList.Where(p => studentScreeningsList.Any(p2 => p2.StudentId == p.StudentId && !p.IsDeleted)).ToList();
                    var studentsNotInScreeningList = studentList.Where(p => !studentScreeningsList.Any(p2 => p2.StudentId == p.StudentId && !p.IsDeleted)).ToList();

                    //   go through each student (studentsNotInScreeningList) : either absent or dont need to be at school
                    if (studentsNotInScreeningList.Count() > 0)
                    {
                        foreach (var stud in studentsNotInScreeningList)
                        {
                            foreach (DateTime day in EachCalendarDay(Convert.ToDateTime(startDateString), Convert.ToDateTime(endDateString)))
                            {
                                if (!CheckIfStudentHasScreeningForDateTime(day, studentScreeningsList, stud.StudentId))
                                {
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
                }
                return returnList;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<AbsenteeViewModel>();
            }
        }

        [Authorize]
        [HttpGet]
        public List<AbsenteeViewModel> GenerateStudentAbsenteeList(String studentId, String startDateString, String endDateString)
        {
            try
            {
                var currentStudent = _context.Students.FirstOrDefault(i => !i.IsDeleted && i.StudentId == Guid.Parse(studentId));
                var studentScreenings = GetStudentScreenings(Guid.Parse(studentId), Convert.ToDateTime(startDateString), Convert.ToDateTime(endDateString));
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

                return returnList;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<AbsenteeViewModel>();
            }
        }

        [Authorize]
        private List<StudentScreening> GetGradeScreenings(Int32 gradeInt, DateTime startDate, DateTime endDate)
        {
            try
            {
                var returnList = _context.StudentScreenings.Where(i => !i.IsDeleted && i.Student.StudentClass.GradeInt == gradeInt &&
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
        private List<StudentScreening> GetStudentScreenings(Guid studentId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var returnList = _context.StudentScreenings.Where(i => !i.IsDeleted && i.StudentId == studentId &&
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
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return new DateRangeViewModel() { MinDateTime = DateTime.Now, MaxDateTime = DateTime.Now };
            }
        }

        #endregion Utilities
    }
}