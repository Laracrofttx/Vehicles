namespace Vehycles.Web.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using Vehycle.Data.Models;
	using Vehycle.Web.ViewModels.Photos;
	using Vehycle.Web.ViewModels.Vehycles;
	using Vehycles.Data;
	using Vehycles.Services.Interfaces;
	using static Vehycle.Common.EntityValidationConstants;

	public class PhotoController : Controller
	{
		private readonly IPhotoService photoService;
		private readonly IWebHostEnvironment environment;
		private readonly VehyclePlatformDbContext dbContext;
		private readonly IVehycleService vehycleService;

		public PhotoController(IWebHostEnvironment environment, IPhotoService photoService, VehyclePlatformDbContext dbContext, IVehycleService vehycleService)
		{
			this.environment = environment;
			this.photoService = photoService;
			this.dbContext = dbContext;
			this.vehycleService = vehycleService;
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
		public async Task<IActionResult> Upload(UploadViewModel model, List<IFormFile> file)
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
				return View(model);
			}

			return RedirectToAction("Index", "Home");

		}



	}

}



