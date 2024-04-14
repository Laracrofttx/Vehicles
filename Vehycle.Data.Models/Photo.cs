namespace Vehycle.Data.Models
{
	using Microsoft.AspNetCore.Http;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Photo
	{
		public Photo()
		{
			this.Id = Guid.NewGuid();
		}

		[Key]
		public Guid Id { get; set; }

		public string FileName { get; set; } = null!;

		public string FileType { get; set; } = null!;

		public byte[] File { get; set; }

		public Guid VehycleId { get; set; }

	}
}
