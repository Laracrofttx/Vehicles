using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vehycle.Web.ViewModels.Photo
{
	public class PhotoViewModel
	{
		public string FileName { get; set; } = null!;
		public string FileType { get; set; } = null!;

		[BindProperty]
		public List<IFormFile> FormFile { get; set; } = null!;
		public Guid VehycleId { get; set; }
	}
}
