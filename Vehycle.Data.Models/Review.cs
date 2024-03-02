namespace Vehycle.Data.Models
{
	using System.ComponentModel.DataAnnotations;

	using static Common.EntityValidationConstants.Review;
	public class Review
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;

		[Required]
		[MaxLength(FeedBackMaxLength)]
		public string FeedBack { get; set; } = null!;

		public DateTime PostedOn { get; set; }

		public ApplicationUser User { get; set; } = null!;
	}
}
