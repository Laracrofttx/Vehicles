using System.ComponentModel.DataAnnotations;

namespace Vehycle.Web.ViewModels.Account
{
    public class LoginRequestModel
    {
        [Required]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; } = null!;
        [Required]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
