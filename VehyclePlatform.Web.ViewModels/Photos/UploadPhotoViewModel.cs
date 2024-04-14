namespace Vehycle.Web.ViewModels.Photos
{
	public class UploadPhotoViewModel
	{
		public Guid Id { get; set; }

		public string FileName { get; set; } = null!;

		public string FileType { get; set; } = null!;

		public byte[] Photos { get; set; } = null!;



	}
}
