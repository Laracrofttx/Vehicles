namespace Vehycle.Data.Models
{
	using System.ComponentModel.DataAnnotations;

	using static Common.EntityValidationConstants.ForumPost;
	public class ForumPost
	{
		public ForumPost()
		{
			this.Id = Guid.NewGuid();

			this.Users = new HashSet<ApplicationUser>();
		}

		[Key]
		public Guid Id { get; set; }

		[Required]
		[MaxLength(ThemeMaxLength)]
		public string Theme { get; set; } = null!;

		[Required]
		[MaxLength(ContentMaxLength)]
		public string Content { get; set; } = null!;

		public DateTime PostedOn { get; set; }

		public ICollection<ApplicationUser> Users { get; set; }

	}
}
