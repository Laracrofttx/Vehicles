namespace Vehycles.Web.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using Vehycle.Web.ViewModels.Photos;
	using Vehycle.Web.ViewModels.Vehycles;
	using Vehycles.Data;
	using Vehycles.Services.Interfaces;

	public class VehycleController : Controller
	{

		private readonly IVehycleService vehycleService;
		private readonly ICategoryService categoryService;
		private readonly IPhotoService photoService;

		public VehycleController(IVehycleService vehycleService, ICategoryService categoryService, IPhotoService photoService, VehyclePlatformDbContext dbContext)
		{
			this.vehycleService = vehycleService;
			this.categoryService = categoryService;
			this.photoService = photoService;
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

				this.ModelState.AddModelError(string.Empty, "Unexepted error occured!");
				return View(vehycle);
			}


			return RedirectToAction("Upload", "Photo");

		}



	}
}
