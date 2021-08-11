using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FreeCourse.Web.Models
{
    public class SingUpInput
    {
        [Required]
        [Display(Name = "Kullanıcı adınız")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Email adresiniz")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Şifreniz")]        
        public string Password { get; set; }

        [Required]
        [Display(Name = "Şifreniz Tekrar")]
        [Compare("Password",ErrorMessage = "Your password and confirm password do not match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Şehriniz")]
        public string City  { get; set; }
    }
}
