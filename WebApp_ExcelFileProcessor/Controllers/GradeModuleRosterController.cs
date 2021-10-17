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
    public class GradeModuleRosterController : Controller
    {
        private readonly ILogger<GradeModuleRosterController> _logger;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public GradeModuleRosterController(ILogger<GradeModuleRosterController> logger, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        #region Views

        public IActionResult Index()
        {
            try
            {
                var currentRecords = _context.GradeModuleRoster.Where(i => !i.IsDeleted).ToList();
                if (currentRecords.Count() == 0)
                    throw new Exception("No grade module roster records found.");
                return View(currentRecords);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View(new List<GradeModuleRoster>());
            }
        }

        public IActionResult AddRosterItem()
        {
            GradeModuleRoster model = new GradeModuleRoster()
            {
                IsDeleted = false,
                DateCreated = DateTime.Now
            };
            model = UpdateRosterItemWithLists(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult AddRosterItem(GradeModuleRoster model)
        {
            try
            {
                var exists = _context.GradeModuleRoster.Any(i => !i.IsDeleted && i.GradeInt == model.GradeInt && i.DayOfWeek == model.DayOfWeek);
                if (exists)
                    throw new Exception("Roster combo already exist for Day of Week and Grade");
                _context.GradeModuleRoster.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return RedirectToAction("Index");
            }
        }

        public IActionResult UpdateRosterItem(String rosterItemId)
        {
            try
            {
                var model = _context.GradeModuleRoster.SingleOrDefault(i => i.GradeModuleRosterId.ToString().ToUpper() == rosterItemId.ToUpper());
                if (model != null)
                {
                    model = UpdateRosterItemWithLists(model);
                    return View(model);
                }
                else
                {
                    return View(new GradeModuleRoster() { });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View(new GradeModuleRoster() { });
            }
        }

        [HttpPost]
        public IActionResult UpdateRosterItem(GradeModuleRoster model)
        {
            try
            {
                var exists = _context.GradeModuleRoster.Any(i => !i.IsDeleted && i.GradeInt == model.GradeInt && i.DayOfWeek == model.DayOfWeek);
                if (exists)
                    throw new Exception("Roster combo already exist for Day of Week and Grade");

                var currModel = _context.GradeModuleRoster.SingleOrDefault(i => i.GradeModuleRosterId == model.GradeModuleRosterId);
                currModel.DayOfWeek = model.DayOfWeek;
                currModel.GradeInt = model.GradeInt;
                currModel.ModuleCodeId = model.ModuleCodeId;
                _context.GradeModuleRoster.Update(currModel);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return RedirectToAction("Index");
            }
        }

        public IActionResult DeleteRosterItem(String rosterItemId)
        {
            try
            {
                var model = _context.GradeModuleRoster.SingleOrDefault(i => i.GradeModuleRosterId.ToString().ToUpper() == rosterItemId.ToUpper());
                if (model != null)
                    return View(model);
                else
                    return View(new GradeModuleRoster() { });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View(new GradeModuleRoster() { });
            }
        }

        [HttpPost]
        public IActionResult DeleteRosterItem(GradeModuleRoster model)
        {
            try
            {
                var currModel = _context.GradeModuleRoster.SingleOrDefault(i => i.GradeModuleRosterId == model.GradeModuleRosterId && !i.IsDeleted);
                currModel.IsDeleted = true;
                _context.GradeModuleRoster.Update(currModel);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return RedirectToAction("Index");
            }
        }

        public IActionResult ViewRosterItem(String rosterItemId)
        {
            try
            {
                var model = _context.GradeModuleRoster.SingleOrDefault(i => i.GradeModuleRosterId.ToString().ToUpper() == rosterItemId.ToUpper());
                if (model != null)
                    return View(model);
                else
                    return View(new RosterViewModel() { });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View(new RosterViewModel() { });
            }
        }

        #endregion Views

        #region Utilities

        [HttpGet]
        public List<RosterViewModel> GetRosterList()
        {
            try
            {
                var rosterList = _context.GradeModuleRoster.Where(i => !i.IsDeleted).ToList();
                if (rosterList.Count() == 0)
                    throw new Exception("No roster records found.");
                return rosterList.Select(i => new RosterViewModel()
                {
                    RosterItemId = i.GradeModuleRosterId.ToString(),
                    GradeNumber = i.GradeInt,
                    Grade = i.GradeInt.ToString(),
                    DayNumber = (Int32)i.DayOfWeek,
                    DayOfWeek = GetDayOfWeek((Int32)i.DayOfWeek),
                    ModuleCode = i.ModuleCode.ModuleCodeName.ToUpper(),
                    DateCreated = i.DateCreated.ToShortDateString()
                }).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<RosterViewModel>();
            }
        }

        private String GetDayOfWeek(Int32 dayInt)
        {
            try
            {
                String returnValue = String.Empty;

                switch (dayInt)
                {
                    case 1:
                        returnValue = "Monday";
                        break;

                    case 2:
                        returnValue = "Tuesday";
                        break;

                    case 3:
                        returnValue = "Wednesday";
                        break;

                    case 4:
                        returnValue = "Thursday";
                        break;

                    case 5:
                        returnValue = "Friday";
                        break;

                    case 6:
                        returnValue = "Saturday";
                        break;

                    case 7:
                        returnValue = "Sunday";
                        break;
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return String.Empty;
            }
        }

        private GradeModuleRoster UpdateRosterItemWithLists(GradeModuleRoster model)
        {
            try
            {
                model.ModuleCodeList = _context.ModuleCodes.ToList().Count() < 0 ? new List<SelectListItem>() : _context.ModuleCodes.ToList().Select(i => new SelectListItem { Value = i.ModuleCodeId.ToString(), Text = i.ModuleCodeName }).OrderBy(i => i.Text); ;
                model.GradeList = new List<SelectListItem>()
                {
                    new SelectListItem(){ Value = "8", Text = "08" },
                    new SelectListItem(){ Value = "9", Text = "09"},
                    new SelectListItem(){ Value = "10", Text = "10" },
                    new SelectListItem(){ Value = "11", Text = "11"},
                    new SelectListItem(){ Value = "12", Text = "12" }
                }.OrderBy(i => i.Text); ;
                model.DayOfWeekList = new List<SelectListItem>()
                {
                    new SelectListItem(){ Value = "1", Text = GetDayOfWeek(1) },
                    new SelectListItem(){ Value = "2", Text = GetDayOfWeek(2) },
                    new SelectListItem(){ Value = "3", Text = GetDayOfWeek(3) },
                    new SelectListItem(){ Value = "4", Text = GetDayOfWeek(4) },
                    new SelectListItem(){ Value = "5", Text = GetDayOfWeek(5) }
                }.OrderBy(i => i.Value); ;

                return model;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                model.ModuleCodeList = new List<SelectListItem>();
                model.GradeList = new List<SelectListItem>();
                model.DayOfWeekList = new List<SelectListItem>();
                return model;
            }
        }

        #endregion Utilities
    }
}