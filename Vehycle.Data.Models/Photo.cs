namespace Vehycle.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	public class Photo
	{
		public Photo()
		{
			this.Id = Guid.NewGuid();
			this.VehycleId = Guid.NewGuid();
		}

		[Key]
		public Guid Id { get; set; }
		public string FileName { get; set; } = null!;
		public string FileType { get; set; } = null!;
		public byte[] FormFile { get; set; } = null!;
		public Guid VehycleId { get; set; }
		public virtual Vehycle Vehycle { get; set; } = null!;
	}
}
