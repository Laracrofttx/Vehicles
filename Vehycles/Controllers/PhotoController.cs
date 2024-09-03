using Microsoft.AspNetCore.Mvc;
using Vehycle.Web.ViewModels.Photo;
using Vehycle.Web.ViewModels.Vehycles;
using Vehycles.Services.Interfaces;

namespace Vehycles.Web.Controllers
{
	public class PhotoController : Controller
	{
		private readonly IPhotoService photoService;
		public PhotoController(IPhotoService photoService)
		{
			this.photoService = photoService;
		}
		public IActionResult Upload()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Upload(VehycleFormModel img, List<IFormFile> file)
		{
			if (!ModelState.IsValid)
			{
				this.ModelState.AddModelError(string.Empty, "Unexpected error occured!");
			}

			try
			{
				await this.photoService.UploadImageAsync(img, file);

			}
			catch (Exception)
			{
				this.ModelState.AddModelError(string.Empty, "Unexpected error occured!");
				return View(img);
			}
			return RedirectToAction("Index", "Home");
		}
	}
}
