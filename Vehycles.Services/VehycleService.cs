namespace Vehycles.Services
{
	using System.Collections.Generic;
	using Microsoft.AspNetCore.Http;
	using Microsoft.EntityFrameworkCore;
	using Vehycle.Data.Models;
	using Vehycle.Web.ViewModels.Vehycles;
	using Vehycles.Data;
	using Vehycles.Services.Interfaces;
	public class VehycleService : IVehycleService
	{
		private readonly VehyclePlatformDbContext dbContext;
		public VehycleService(VehyclePlatformDbContext dbContext)
		{
			this.dbContext = dbContext;
		}
		public async Task AddVehycleAsync(VehycleFormModel vehycles)
		{
			var vehycle = new Vehycle
			{
				Id = vehycles.Id,
				Brand = vehycles.Brand,
				Model = vehycles.Model,
				Year = vehycles.Year,
				Price = vehycles.Price,
				Color = vehycles.Color,
				Doors = vehycles.Doors,
				Condition = vehycles.Condition,
				HorsePower = vehycles.HorsePower,
				Transmition = vehycles.Transmition,
				EuStandart = vehycles.EuroStrandart,
				VehycleInfo = vehycles.VehycleInfo,
				VehycleType = vehycles.VehycleType,
				CategoryId = vehycles.CategoryId,
			};
            await dbContext.Vehycles.AddAsync(vehycle);
			await dbContext.SaveChangesAsync();
		}
		public async Task<IEnumerable<VehycleCategoriesViewModel>> AllVehycleCategoriesAsync()
		{
			var categories = await this.dbContext
				.Categories
				.AsNoTracking()
				.Select(c => new VehycleCategoriesViewModel()
				{
					Id = c.Id,
					Name = c.Name,
				})
				.ToArrayAsync();

			return categories;
		}
	}
}
