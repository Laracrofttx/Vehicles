namespace Vehycle.Data.Models
{
	using Microsoft.AspNetCore.Identity;
	using System.ComponentModel.DataAnnotations;

	using static Common.EntityValidationConstants.User;

	public class ApplicationUser : IdentityUser<Guid>
	{
        public ApplicationUser()
        {
			this.Id = Guid.NewGuid();

			this.ForumPosts = new HashSet<ForumPost>();
			this.PostedAd = new HashSet<Ad>();
        }


		[Required]
		[MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

		[Required]
		[MaxLength(LastNameMaxLength)]
		public string LastName { get; set; } = null!;

		public virtual ICollection<ForumPost> ForumPosts { get; set; }

		public virtual ICollection<Ad> PostedAd { get; set; }

	}
}
