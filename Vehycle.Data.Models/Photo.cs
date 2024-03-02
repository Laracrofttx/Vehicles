namespace Vehycle.Data.Models
{
	public class Photo
	{
        public Photo()
        {
			this.Id = Guid.NewGuid();

        }

        public Guid Id {get; set;}

		public string FileName { get; set; } = null!;

		public int VehycleId { get; set; }

		public Vehycle Vehycle { get; set; } = null!;
	}
}
