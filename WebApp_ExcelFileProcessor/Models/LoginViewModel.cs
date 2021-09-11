using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_ExcelFileProcessor.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "A email is required.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email", AutoGenerateFilter = false)]
        [MaxLength(30, ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password", AutoGenerateFilter = false)]
        [MinLength(5, ErrorMessage = "Please enter a valid password.")]
        [MaxLength(15, ErrorMessage = "Please enter a valid password.")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; } = true;
    }
}
