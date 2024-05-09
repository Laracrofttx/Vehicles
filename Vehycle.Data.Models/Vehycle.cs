namespace Vehycle.Data.Models
{
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Mvc;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using static Common.EntityValidationConstants.Vehycle;
	public class Vehycle
	{

		public Vehycle()
		{
			this.Id = Guid.NewGuid();
			this.Images = new HashSet<Photo>(); 
		}

		[Key]
		public Guid Id { get; set; }

		[Required]
		[MaxLength(BrandNameMaxLength)]
		public string Brand { get; set; } = null!;

		[Required]
		[MaxLength(ModelNameMaxLength)]
		public string Model { get; set; } = null!;

		[Required]
		public int Year { get; set; }

		[Required]
		public string Color { get; set; } = null!;

		[Required]
		public string EuStandart { get; set; } = null!;

		[Required]
		public decimal Price { get; set; }

		[Required]
		public string VehycleType { get; set; } = null!;

		[Required]
		public string VehycleInfo { get; set; } = null!;

		[Required]
		public string Transmition { get; set; } = null!;

		[Required]
		public int HorsePower { get; set; }

		[Required]
		public int Doors { get; set; }

		[Required]
		public string Condition { get; set; } = null!;

		public int CategoryId { get; set; }

		public virtual Category Category { get; set; } = null!;

		public virtual ICollection<Photo> Images { get; set; } = null!;

		public static implicit operator Guid(Vehycle v)
		{
			throw new NotImplementedException();
		}
	}
}
