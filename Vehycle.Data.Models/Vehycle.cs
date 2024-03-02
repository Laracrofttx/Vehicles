namespace Vehycle.Data.Models

{
	public class Vehycle
	{

		public Vehycle()
		{
			this.Id = Guid.NewGuid();

			this.Photos = new HashSet<Photo>();
		}

		public Guid Id { get; set; }

		public string Brand { get; set; } = null!;

		public string Model { get; set; } = null!;

		public int Year { get; set; }

		public string Color { get; set; } = null!;

		public string EuStandart { get; set; } = null!;

		public decimal Price { get; set; }

		public string VehycleType { get; set; } = null!;

		public string VehycleInfo { get; set; } = null!;

		public string Transmition { get; set; } = null!;

		public int HorsePower { get; set; }

		public int Doors { get; set; }

		public string Condition { get; set; } = null!;

		public int CategoryId { get; set; }

		public Category Category { get; set; } = null!;

		public ICollection<Photo> Photos { get; set; } = null!;

	}
}
