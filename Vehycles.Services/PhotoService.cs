namespace Vehycles.Services
{
	using System.IO;
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

		public async Task<Photo> Save(Photo photo)
		{
			await this.dbContext.Photos.AddAsync(photo);
			await this.dbContext.SaveChangesAsync();

			return photo;
		}

		public async Task UploadImageAsync(UploadPhotoViewModel photo)
		{
			string fileName = Path.GetFileName(photo.FileName);
			string fileType = photo.FileType;

			using (var ms = new MemoryStream())
			{
				var newFile = new Photo()
				{

					Id = photo.Id,
					FileName = fileName,
					FileType = fileType,
					File = photo.Photos,

				};

				await this.dbContext.Photos.AddAsync(newFile);
				await this.dbContext.SaveChangesAsync();
			}
		}

	}
}
