using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections;
using Vehycle.Data.Models;
using Vehycle.Web.ViewModels.Photos;
using Vehycles.Data;
using Vehycles.Services.Interfaces;

namespace Vehycles.Services
{
	public class PhotoService : IPhotoService
	{
		private readonly VehyclePlatformDbContext dbContext;
		private readonly IWebHost webHost;

		public PhotoService(VehyclePlatformDbContext dbContext, IWebHost webHost)
		{
			this.dbContext = dbContext;
			this.webHost = webHost;

		}

		public Task<IEnumerable> UploadedPhotos(Photo photo)
		{
			throw new NotImplementedException();
		}


		//public async Task<IActionResult> UploadedPhotos(Vehycle.Data.Models.Photo photo)
		//{
		//	byte[] bytes = null;


		//	if (photo.Image != null)
		//	{
		//		using (Stream strl = photo.Image.OpenReadStream())
		//		{
		//			using (BinaryReader br = new BinaryReader(strl))
		//			{
		//				bytes = br.ReadBytes((int)strl.Length);
		//			}
		//		}

		//		photo.FileName = Convert.ToBase64String(bytes);

		//		await this.dbContext.Photos.AddAsync(photo);
		//		await this.dbContext.SaveChangesAsync();
		//	}


		//}


	}
}
