namespace Vehycle.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	using static Common.EntityValidationConstants.Contact;

	public class Contact
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[MaxLength(EmailAdressMaxLength)]
		public string Email { get; set; } = null!;
		[Required]
		[MaxLength(PhoneNumberMaxLength)]
		public string PhoneNumber { get; set; } = null!;
		[Required]
		[MaxLength(MessageMaxLength)]
		public string Message { get; set; } = null!;
	}
}
