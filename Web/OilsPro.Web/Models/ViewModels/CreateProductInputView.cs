using System.ComponentModel.DataAnnotations;

namespace OilsPro.Web.Models.ViewModels
{
    public class CreateProductInputView
    {
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [RegularExpression("[0-9]{8}", ErrorMessage = "Format must be eight numbers from 0 to 9")]
        public string ProductCode { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string Viscosity { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int PackageCapacity { get; set; }

        public decimal PackageWeight { get; set; }
    }
}
