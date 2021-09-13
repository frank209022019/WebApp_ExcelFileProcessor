using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApp_ExcelFileProcessor.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public DashboardController(ILogger<HomeController> logger, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
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