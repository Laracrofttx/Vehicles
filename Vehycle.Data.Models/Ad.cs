namespace Vehycle.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	public class Ad
	{
		public Ad()
		{
			this.Id = Guid.NewGuid();
		}

		[Key]
		public Guid Id { get; set; }

		public DateTime PostedOn { get; set; }

		public ApplicationUser PostedBy { get; set; } = null!;
	}
}
