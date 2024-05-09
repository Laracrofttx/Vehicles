namespace Vehycles.Data
{
	using System.Reflection;

	using Microsoft.AspNetCore.Identity;
	using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore;
    using Vehycle.Data.Configurations;
    using Vehycle.Data.Models;
	using Vehycle.Data.Seeding;

	public class VehyclePlatformDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
	{
		private readonly bool seedDb;
		public VehyclePlatformDbContext(DbContextOptions<VehyclePlatformDbContext> options)
			: base(options)
		{
		}

		public DbSet<About> AboutUs { get; set; }

		public DbSet<Ad> Ads { get; set; }

		public DbSet<ApplicationUser> User { get; set; }

		public DbSet<Category> Categories { get; set; }

		public DbSet<Chat> Chats { get; set; }

		public DbSet<Contact> ContactUs { get; set; }

		public DbSet<ForumPost> ForumPosts { get; set; }

		public DbSet<Message> Messages { get; set; }

		public DbSet<Photo> Photos { get; set; }

		public DbSet<Review> Reviews { get; set; }

		public DbSet<Vehycle> Vehycles { get; set; }

		public DbSet<VehycleAd> VehycleAds { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			
			builder.Entity<VehycleAd>()
				.HasKey(c => new { c.VehycleId, c.AdId });

			builder.Entity<Vehycle>()
				.HasMany(v => v.Images);

			builder.Entity<Photo>()
				.HasOne(c => c.Vehycle)
				.WithMany(c => c.Images)
				.HasForeignKey(c => c.VehycleId)
				.OnDelete(DeleteBehavior.Restrict);
				

			
			if (this.seedDb)
			{
				builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
			}
			

			base.OnModelCreating(builder);

		}

    }
}
