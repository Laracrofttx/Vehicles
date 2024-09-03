using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vehycle.Web.ViewModels.Photo
{
	public class PhotoViewModel
	{
		public string FileName { get; set; } 
		public string FileType { get; set; } 

		[BindProperty]
		public List<IFormFile> FormFile { get; set; } 
		public Guid VehycleId { get; set; }
	}
}
