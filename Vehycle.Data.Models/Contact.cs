namespace Vehycle.Data.Models
{
	using System.ComponentModel.DataAnnotations;

	public class Contact
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Email { get; set; } = null!;
		[Required]
		public string PhoneNumber { get; set; } = null!;
		[Required]
		public string Message { get; set; } = null!;
	}
}
