using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using WebApp_ExcelFileProcessor.Data;
using WebApp_ExcelFileProcessor.ViewModels;

namespace WebApp_ExcelFileProcessor.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public DashboardController(ILogger<HomeController> logger, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            DashboardViewModel model = new DashboardViewModel();
            model.HasStudentRecords = _context.Students.Any();
            model.HasScreeningRecords = _context.Students.Any();

            return View(model);
        }

        [Authorize]
        public IActionResult UploadBaseClass()
        {
            return RedirectToAction("UploadBaseClass", "BaseClass");
        }

        [Authorize]
        public IActionResult ManageBaseClass()
        {
            return RedirectToAction("ManageBaseClass", "BaseClass");
        }

        [Authorize]
        public IActionResult Signout()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}