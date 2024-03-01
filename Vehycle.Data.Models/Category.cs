namespace Vehycle.Data.Models
{
	public class Category
	{
        public Category()
        {
			this.Vehycles = new HashSet<Vehycle>();
        }

        public int Id { get; set; }

		public string Name { get; set; } = null!;

		public ICollection<Vehycle> Vehycles { get; set; } = null!;
	}
}
