namespace Vehycle.Web.ViewModels.Vehycles
{
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Mvc;
	using System.ComponentModel.DataAnnotations;
    using Vehycle.Data.Models;

    using static Vehycle.Common.EntityValidationConstants.Vehycle;

    public class VehycleFormModel
    {
        public VehycleFormModel()
        {
            Id = Guid.NewGuid();

            Categories = new HashSet<VehycleCategoriesViewModel>();
            Photos = new HashSet<Photo>();
        }
        public Guid Id { get; set; }

        [Required]
        [StringLength(BrandNameMaxLength, MinimumLength = BrandNameMinLength, ErrorMessage = "The field must contain atleast {2} symbols")]
        public string Brand { get; set; } = null!;

        [Required]
        [StringLength(ModelNameMaxLength, MinimumLength = ModelNameMinLength, ErrorMessage = "The field must contain atleast {2} symbols")]
        public string Model { get; set; } = null!;

        [Required]
        public int Year { get; set; }

        [Required]
        public string Color { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string VehycleType { get; set; } = null!;

        [Required]
        [Display(Name = "Details")]
        [StringLength(VehycleInfoMaxLength, MinimumLength = VehycleInfoMinLength, ErrorMessage = "The field must contain atleast {2} symbols")]
        public string VehycleInfo { get; set; } = null!;

        [Required]
        public string Transmition { get; set; } = null!;

        [Required]
        [Display(Name = "Horse Power(hp)")]
        public int HorsePower { get; set; }

        [Required]
        public int Doors { get; set; }

        [Required]
        [Display(Name = "EU")]
        public string EuroStrandart { get; set; } = null!;

        [Required]
        public string Condition { get; set; } = null!;

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public IEnumerable<VehycleCategoriesViewModel> Categories { get; set; }
        public List<IFormFile> Photo { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
	}
}
