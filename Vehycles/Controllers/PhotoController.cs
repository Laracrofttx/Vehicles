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
		public async Task<IActionResult> Upload(PhotoViewModel model, List<IFormFile> file)
		{
			if (!ModelState.IsValid)
			{
				this.ModelState.AddModelError(string.Empty, "Unexpected error occured!");
			}

			try
			{
				await this.photoService.UploadImageAsync(model, file);

			}
			catch (Exception)
			{
				this.ModelState.AddModelError(string.Empty, "Unexpected error occured!");
				return View(file);
			}
			return RedirectToAction("Form", "Vehycle");
		}
	}
}
