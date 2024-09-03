namespace Vehycles.Services.Interfaces
{
	using Microsoft.AspNetCore.Http;
	using Vehycle.Web.ViewModels.Vehycles;
	public interface IPhotoService
	{
		Task UploadImageAsync(VehycleFormModel model, List<IFormFile> file);
	}
}
