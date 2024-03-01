namespace Vehycle.Data.Models
{
	public class Contact
	{
		public int Id { get; set; }

		public string Email { get; set; } = null!;

		public string PhoneNumber { get; set; } = null!;

		public string Message { get; set; } = null!;
	}
}
