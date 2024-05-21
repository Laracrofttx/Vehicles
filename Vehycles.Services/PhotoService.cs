namespace Vehycles.Services
{
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Threading.Tasks;
	using Microsoft.AspNetCore.Http;
	using Microsoft.EntityFrameworkCore;
	using Vehycle.Data.Models;
	using Vehycle.Web.ViewModels.Photos;
	using Vehycles.Data;
	using Vehycles.Services.Interfaces;

	public class PhotoService : IPhotoService
	{
		private readonly VehyclePlatformDbContext dbContext;

		public PhotoService(VehyclePlatformDbContext dbContext)
		{
			this.dbContext = dbContext;

		}

		
		public async Task UploadImageAsync(UploadViewModel model, List<IFormFile> file)
		{

			foreach (var photo in file)
			{

				using (var memoryStream = new MemoryStream())
				{

					var lastVehycleId = await this.dbContext
						.Vehycles
						.OrderByDescending(c => c.Id)
						.FirstOrDefaultAsync();
						
						

					var fileExtension = Path.GetExtension(photo.FileName);
					var fileName = Path.GetFileName(photo.FileName);
					var newFile = new Photo()
					{
						Id = model.Id,
						FileName = fileName,
						FileType = fileExtension,
						FormFile = memoryStream.ToArray(),
						VehycleId = lastVehycleId!.Id

					};

					await dbContext.Photos.AddAsync(newFile);
					await dbContext.SaveChangesAsync();
				}


			}
		}
	}
}

