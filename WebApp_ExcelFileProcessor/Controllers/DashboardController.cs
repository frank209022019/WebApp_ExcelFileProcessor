using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using WebApp_ExcelFileProcessor.Data;
using WebApp_ExcelFileProcessor.ViewModels;

namespace WebApp_ExcelFileProcessor.Controllers
{
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

        public IActionResult Index()
        {
            DashboardViewModel model = new DashboardViewModel();
            model.HasStudentRecords = _context.Students.Any();
            model.HasScreeningRecords = _context.Students.Any();

            return View(model);
        }

        public IActionResult UploadBaseClass()
        {
            return RedirectToAction("UploadBaseClass", "BaseClass");
        }

        public IActionResult ManageBaseClass()
        {
            return RedirectToAction("ManageBaseClass", "BaseClass");
        }

        public IActionResult Signout()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}