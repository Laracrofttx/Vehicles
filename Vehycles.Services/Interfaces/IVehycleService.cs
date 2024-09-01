﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vehycle.Web.ViewModels.Photos;
using Vehycle.Web.ViewModels.Vehycles;

namespace Vehycles.Services.Interfaces
{
    public interface IVehycleService
    {
		Task AddVehycleAsync(VehycleFormModel vehycle);
		Task<IEnumerable<VehycleCategoriesViewModel>> AllVehycleCategoriesAsync();
		Task UploadImageAsync(UploadViewModel model, List<IFormFile> file);
	}
}
