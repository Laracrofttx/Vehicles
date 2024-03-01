namespace Vehycle.Data.Models
{
	public class Review
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public string FeedBack { get; set; } = null!;

		public DateTime PostedOn { get; set; }

		public ApplicationUser User { get; set; } = null!;
	}
}
