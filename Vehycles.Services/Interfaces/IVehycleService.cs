using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vehycle.Web.ViewModels.Vehycles;

namespace Vehycles.Services.Interfaces
{
    public interface IVehycleService
    {
		Task AddVehycleAsync(VehycleFormModel vehycle, List<IFormFile> imgs);
		Task<IEnumerable<VehycleCategoriesViewModel>> AllVehycleCategoriesAsync();
		//Task UploadImageAsync(VehycleFormModel model, List<IFormFile> file);
	}
}
