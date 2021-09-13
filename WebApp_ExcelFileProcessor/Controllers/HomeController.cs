using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using WebApp_ExcelFileProcessor.ViewModels;

namespace WebApp_ExcelFileProcessor.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(SignInManager<IdentityUser> signInManager, ILogger<HomeController> logger, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            bool userLoggedIn = User.Identity.IsAuthenticated;
            if(userLoggedIn)
            {
               return  RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View(new LoginViewModel() { Email = String.Empty, Password = String.Empty, RememberMe = true });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // This doesn't count login failures towards account lockout
                    // To enable password failures to trigger account lockout, set lockoutOnFailure: true

                    var user = await _userManager.FindByEmailAsync(model.Email);
                    if (user == null)
                    {
                        ModelState.AddModelError(string.Empty, "User not found.");
                        model.Email = String.Empty;
                        model.Password = String.Empty;
                        model.RememberMe = true;
                        return View();
                    }

                    //var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                    var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);

                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User logged in.");
                        return RedirectToAction("Index", "Dashboard");
                        //return LocalRedirect(returnUrl);
                    }
                    //if (result.RequiresTwoFactor)
                    //{
                    //    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                    //}
                    if (result.IsLockedOut)
                    {
                        //_logger.LogWarning("User account locked out.");
                        //return RedirectToPage("./Lockout");
                        ModelState.AddModelError(string.Empty, "User account locked out.");
                        model.Email = String.Empty;
                        model.Password = String.Empty;
                        model.RememberMe = true;
                        return View();
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                        model.Email = String.Empty;
                        model.Password = String.Empty;
                        model.RememberMe = true;
                        return View();
                    }
                }

                // If we got this far, something failed, redisplay form
                model.Email = "";
                model.Password = "";
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}