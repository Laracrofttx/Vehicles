namespace Vehycle.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Vehycle.Data.Models;

    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(GenerateCategories());
        }

        private Category[] GenerateCategories()
        {

            ICollection<Category> categories = new HashSet<Category>();

            Category category;

            category = new Category
            {
                Id = 1,
                Name = "Cars"

            };
            categories.Add(category);

            category = new Category
            {

                Id = 2,
                Name = "Motorcycles"

            };
            categories.Add(category);

            category = new Category
            {
                Id = 3,
                Name = "Buses",

            };
            categories.Add(category);

            category = new Category
            {
                Id = 4,
                Name = "Trucks"

            };
            categories.Add(category);

            return categories.ToArray();

        }
    }
}



