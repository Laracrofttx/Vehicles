using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using Vehycle.Data.Models;
using Vehycle.Web.ViewModels.Photos;

namespace Vehycles.Services.Interfaces
{
	public interface IPhotoService
	{

		Task UploadImageAsync(UploadPhotoViewModel photo);

	}
}
