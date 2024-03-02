namespace Vehycle.Data.Models
{
	using Microsoft.AspNetCore.Identity;
	public class ApplicationUser : IdentityUser<Guid>
	{
        public ApplicationUser()
        {
			this.Id = Guid.NewGuid();

			this.ForumPosts = new HashSet<ForumPost>();
			this.PostedAd = new HashSet<Ad>();
        }


        public string FirstName { get; set; } = null!;

		public string LastName { get; set; } = null!;

		public ICollection<ForumPost> ForumPosts { get; set; }

		public ICollection<Ad> PostedAd { get; set; }

	}
}
