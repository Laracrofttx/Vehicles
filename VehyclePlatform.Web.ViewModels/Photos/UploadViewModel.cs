namespace Vehycle.Web.ViewModels.Photos
{
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Mvc;
	using Data.Models;
	public class UploadViewModel
	{
		public Guid Id { get; set; }
		public string FileName { get; set; } = null!;
		public string FileType { get; set; } = null!;

		[BindProperty]
		public List<IFormFile> FormFile { get; set; } = null!;
		public Guid VehycleId { get; set; } 
	}
}
