namespace Vehycle.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	using static Common.EntityValidationConstants.Category;

	public class Category
	{
		public Category()
		{
			this.Vehycles = new HashSet<Vehycle>();
		}

		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;
		public virtual ICollection<Vehycle> Vehycles { get; set; } = null!;
	}
}
