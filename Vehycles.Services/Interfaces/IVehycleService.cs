﻿using Vehycle.Web.ViewModels.Vehycles;

namespace Vehycles.Services.Interfaces
{
    public interface IVehycleService
    {
		Task AddVehycleAsync(VehycleFormModel vehycle);

		Task<IEnumerable<VehycleCategoriesViewModel>> AllVehycleCategoriesAsync();

	}
}
