using System.ComponentModel.DataAnnotations;

namespace Vehycle.Web.ViewModels.Account
{
	public class RegisterViewModel
	{
		[Required]
		[Display(Name = "First name")]
		public string FirstName { get; set; }
		[Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
		[Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }
		[Required]
		[Display(Name = "Email Address")]
		public string EmailAddress { get; set; }
		[Required]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required]
        public int Age { get; set; }
		[Required]
        public string Gender { get; set; } = null!;
		[Required]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }

    }
}
