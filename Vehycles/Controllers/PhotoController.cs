using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Vehycle.Data.Models;
using Vehycle.Web.ViewModels.Photos;
using Vehycle.Web.ViewModels.Vehycles;
using Vehycles.Data;
using Vehycles.Services.Interfaces;

namespace Vehycles.Web.Controllers
{
	public class PhotoController : Controller
	{
		private readonly IWebHostEnvironment environment;

		public PhotoController(IWebHostEnvironment environment)
		{
			this.environment = environment;
		}

		[HttpGet]
		public IActionResult Upload()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Upload(List<IFormFile> photos)
		{
			string uploadFolder = Path.Combine(environment.WebRootPath, "images");

			if (!Directory.Exists(uploadFolder))
			{
				Directory.CreateDirectory(uploadFolder);
			}

			foreach (var photo in photos)
			{

				string fileName = Path.GetFileName(photo.FileName);

				string fileSavePath = Path.Combine(uploadFolder, fileName);

				using (FileStream stream = (new FileStream(fileSavePath, FileMode.Create)))
				{

					await photo.CopyToAsync(stream);
				}

				ViewBag.Message = fileName + " uploaded succefully";
			}

			return View();
		}


	}
}
