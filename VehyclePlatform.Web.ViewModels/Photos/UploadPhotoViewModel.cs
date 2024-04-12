namespace Vehycle.Web.ViewModels.Photos
{
	using Microsoft.AspNetCore.Http;
	using Vehycle.Data.Models;
	public class UploadPhotoViewModel
	{
		public Guid Id { get; set; }

		public string FileName { get; set; } = null!;

		public Vehycle Vehycles { get; set; } = null!;

		public IFormFile Photos { get; set; } = null!;
	}
}
