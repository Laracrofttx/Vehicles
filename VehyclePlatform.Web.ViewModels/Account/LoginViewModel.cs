using System.ComponentModel.DataAnnotations;

namespace Vehycle.Web.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
