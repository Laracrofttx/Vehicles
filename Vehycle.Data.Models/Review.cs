namespace Vehycle.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	public class Review
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; } = null!;

		[Required]
		public string FeedBack { get; set; } = null!;
		public DateTime PostedOn { get; set; }
		public virtual ApplicationUser User { get; set; } = null!;
	}
}
