using System.ComponentModel.DataAnnotations;

namespace Vehycle.Web.ViewModels.Account
{
    public class LoginRequestModel
    {
        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; } 
        [Required]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }   
    }
}
