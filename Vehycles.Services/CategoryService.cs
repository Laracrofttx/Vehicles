using Microsoft.EntityFrameworkCore;
using Vehycles.Data;
using Vehycles.Services.Interfaces;

namespace Vehycles.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly VehyclePlatformDbContext dbContext;

        public CategoryService(VehyclePlatformDbContext dbContext)
        {
				this.dbContext = dbContext;
        }
        public async Task<bool> CategoryExistByIdAsync(int Id)
		{
			bool categoryExist = await this.dbContext
				.Categories
				.AnyAsync (c => c.Id == Id);

			return categoryExist;
		}
	}
}
