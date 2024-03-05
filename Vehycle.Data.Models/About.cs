namespace Vehycle.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	public class About
	{
		[Key]
		public int Id { get; set; }
		public string Image { get; set; } = null!;

		public string AboutUs { get; set; } = null!;
	}
}
