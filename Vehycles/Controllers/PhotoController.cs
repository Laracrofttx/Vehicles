namespace Vehycles.Web.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using Newtonsoft.Json;
	using Vehycle.Data.Models;
	using Vehycle.Web.ViewModels.Photos;
	using Vehycles.Services.Interfaces;
	public class PhotoController : Controller
	{
		private readonly IPhotoService photoService;
		private readonly IWebHostEnvironment environment;

		public PhotoController(IWebHostEnvironment environment, IPhotoService photoService)
		{
			this.environment = environment;
			this.photoService = photoService;
		}

		[HttpGet]
		public IActionResult Upload()
		{
			return View();
		}

		//[HttpPost]
		//public async Task<IActionResult> Upload(List<IFormFile> photos)
		//{
		//	string uploadFolder = Path.Combine(environment.WebRootPath, "images");

		//	if (!Directory.Exists(uploadFolder))
		//	{
		//		Directory.CreateDirectory(uploadFolder);
		//	}

		//	foreach (var photo in photos)
		//	{

		//		string fileName = Path.GetFileName(photo.FileName);

		//		string fileSavePath = Path.Combine(uploadFolder, fileName);

		//		using (FileStream stream = (new FileStream(fileSavePath, FileMode.Create)))
		//		{

		//			await photo.CopyToAsync(stream);
		//		}

		//		ViewBag.Message = fileName + " uploaded succefully";
		//	}

		//	return View();
		//}

		[HttpPost]
		public async Task<IActionResult> Upload(UploadPhotoViewModel photo)
		{
			try
			{
				await this.photoService.UploadImageAsync(photo);

			}
			catch (Exception)
			{

				this.ModelState.AddModelError(string.Empty, "Unexpected error occured!");
				return View(photo);
			}

			return RedirectToAction("Index", "Home");
		}

	}
}
