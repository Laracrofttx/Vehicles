namespace Vehycles.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Vehycle.Web.ViewModels.Vehycles;
    using Vehycles.Services.Interfaces;

    public class VehycleController : Controller
	{
		private readonly IVehycleService vehycleService;
		private readonly ICategoryService categoryService;

		public VehycleController(IVehycleService vehycleService, ICategoryService categoryService)
		{
			this.vehycleService = vehycleService;
			this.categoryService = categoryService;
		}

		[HttpGet]
		public async Task<IActionResult> Form()
		{

			return View(new VehycleFormModel
			{

				Categories = await this.vehycleService.AllVehycleCategoriesAsync()
			});
		}


		[HttpPost]
		public async Task<IActionResult> Form(VehycleFormModel vehycle)
		{
			if (!await this.categoryService.CategoryExistByIdAsync(vehycle.CategoryId))
			{
				ModelState.AddModelError(nameof(vehycle.CategoryId), "Category does not exist!");

			}

			try
			{
				await this.vehycleService.AddVehycleAsync(vehycle);

			}
			catch (Exception)
			{

				throw new InvalidOperationException();

			}

			return RedirectToAction("Index", "Home");
		
		}

	}
}
