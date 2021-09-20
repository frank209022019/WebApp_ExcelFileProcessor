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
                var model = _context.Students.Where(i => !i.IsDeleted).Select(i => new SelectListItem() { Value = i.StudentId.ToString(), Text = String.Format(" [{0}] {1} {2}", i.StudentClass.DisplayName, i.FirstName, i.LastName) }).ToList();
                return View(model);
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
        public List<AbsenteeViewModel> GenerateSchoolAbsenteeList(String startDateString, String endDateString)
        {
            try
            {
                DateTime startDate = Convert.ToDateTime(startDateString);
                DateTime endDate = Convert.ToDateTime(endDateString);

                //  Screening list            
                var screeningList = GetStudentScreeningForDateRange(startDate, endDate);
                if (screeningList.Count() <= 0)
                    throw new Exception("No student screenings found.");

                //  Student list
                var studentList = _context.Students.Where(i => !i.IsDeleted).ToList();
                if (studentList.Count() <= 0)
                    throw new Exception("No students found.");

                //  Return list
                List<AbsenteeViewModel> returnList = new List<AbsenteeViewModel>();

                //  Process for absentee records
                foreach (var item in studentList)
                {
                    //  get screennings for student
                    var studentScreenings = screeningList.Where(i => i.StudentId == item.StudentId).ToList();
                    if (studentScreenings.Count() > 0)
                    {
                        //  loop through DateRange to find absentt days (is at school some days in DateRange)
                        foreach (DateTime day in EachCalendarDay(startDate, endDate))
                        {
                            var recordExists = studentScreenings.Any(i => i.ScrenningTimeStamp.Day == day.Day &&
                                                                                                                      i.ScrenningTimeStamp.Month == day.Month &&
                                                                                                                      i.ScrenningTimeStamp.Year == day.Year);
                            if (!recordExists)
                                returnList.Add(new AbsenteeViewModel()
                                {
                                    StudentId = item.StudentId,
                                    AbsentDateTime = day
                                });
                        }
                    }
                    else
                    {
                        //  add a new record for each day (student absent every day in the DateRange)
                        foreach (DateTime day in EachCalendarDay(startDate, endDate))
                        {
                            returnList.Add(new AbsenteeViewModel()
                            {
                                StudentId = item.StudentId,
                                AbsentDateTime = day
                            });
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
                DateTime startDate = Convert.ToDateTime(startDateString);
                DateTime endDate = Convert.ToDateTime(endDateString);

                //  Screening list
                var screeningList = GetStudentScreeningForDateRange(startDate, endDate);
                if (screeningList.Count() <= 0)
                    throw new Exception("No student screenings found.");

                //  Student list
                var student = _context.Students.FirstOrDefault(i => i.StudentId.ToString().ToUpper() == studentId.ToUpper() && !i.IsDeleted);
                if (student == null)
                    throw new Exception("No student found.");

                //  Return list
                List<AbsenteeViewModel> returnList = new List<AbsenteeViewModel>();

                //  Process for absentee records
                var studentScreenings = screeningList.Where(i => i.StudentId == student.StudentId).ToList();
                if (studentScreenings.Count() > 0)
                {
                    //  loop through DateRange to find absentt days (is at school some days in DateRange)
                    foreach (DateTime day in EachCalendarDay(startDate, endDate))
                    {
                        //  check in studentScreenings if record exists for day in DateRange
                        var recordExists = studentScreenings.Any(i => i.ScrenningTimeStamp.Day == day.Day &&
                                                                                                                     i.ScrenningTimeStamp.Month == day.Month &&
                                                                                                                     i.ScrenningTimeStamp.Year == day.Year);
                        if (!recordExists)
                            returnList.Add(new AbsenteeViewModel()
                            {
                                StudentId = student.StudentId,
                                AbsentDateTime = day
                            });
                    }
                }
                else
                {
                    //  add a new record for each day (student absent every day in the DateRange)
                    foreach (DateTime day in EachCalendarDay(startDate, endDate))
                    {
                        returnList.Add(new AbsenteeViewModel()
                        {
                            StudentId = student.StudentId,
                            AbsentDateTime = day
                        });
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

        private List<StudentScreening> GetStudentScreeningForDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                var returnList = _context.StudentScreenings.Where(i => !i.IsDeleted && 
                                                                                                                    (i.ScrenningTimeStamp.Year >= startDate.Year && i.ScrenningTimeStamp.Year >= endDate.Year) &&
                                                                                                                    (i.ScrenningTimeStamp.Month >= startDate.Month && i.ScrenningTimeStamp.Month >= endDate.Month) &&
                                                                                                                    (i.ScrenningTimeStamp.Day >= startDate.Day && i.ScrenningTimeStamp.Day >= endDate.Day)).ToList();
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

        private IEnumerable<DateTime> EachCalendarDay(DateTime startDate, DateTime endDate)
        {
            for (var date = startDate.Date; date.Date <= endDate.Date; date = date.AddDays(1)) yield
            return date;
        }

        private String GenerateStudentFullNameWithClass(Student student)
        {
            try
            {
                return String.Format(" [{0}] {1} {2}", student.StudentClass.DisplayName, student.FirstName, student.LastName);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return String.Empty;
            }
        }

        #endregion Utilities
    }
}