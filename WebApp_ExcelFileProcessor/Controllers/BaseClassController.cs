using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_ExcelFileProcessor.Data;

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
        [Authorize]
        public IActionResult UploadBaseClass()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult UploadBaseClass(List<IFormFile> files)
        {
            try
            {
                return Ok(new { success = true, message = "All files uploaded successfully!" });
            }
            catch(Exception ex)
            {
                return BadRequest(new { success = false, message = "Error while uploading files!" });
            }
            return View();
        }

        [Authorize]
        public IActionResult ManageBaseClass()
        {
            return View();
        }
    }
}
