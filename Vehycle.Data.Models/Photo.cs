namespace Vehycle.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	public class Photo
	{
		public Photo()
		{
			this.Id = Guid.NewGuid();

		}

		[Key]
		public Guid Id { get; set; }

		public string FileName { get; set; } = null!;

		public int VehycleId { get; set; }

		public Vehycle Vehycle { get; set; } = null!;
	}
}
