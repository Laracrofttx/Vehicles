namespace Vehycle.Data.Configurations
{
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using Vehycle.Data.Models;
	public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{
		public void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
			builder
				.Property(f => f.FirstName)
				.HasDefaultValue("John");

			builder
				.Property(l => l.LastName)
				.HasDefaultValue("Smith");
		}
	}
}

