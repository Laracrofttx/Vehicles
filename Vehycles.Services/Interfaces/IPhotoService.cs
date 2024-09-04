namespace Vehycles.Services.Interfaces
{
	using Microsoft.AspNetCore.Http;
	using Vehycle.Web.ViewModels.Photo;

	public interface IPhotoService
	{
		Task UploadImageAsync(PhotoViewModel model, List<IFormFile> file);
	}
}
