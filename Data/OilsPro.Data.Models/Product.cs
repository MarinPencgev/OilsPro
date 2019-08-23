using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OilsPro.Data.Models
{
    public class Product
    {
        public Product()
        {
            this.Lots = new List<Lot>();
        }
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(8)]
        [RegularExpression("[0-9]")]
        public string ProductCode { get; set; }

        [Required]
        [MaxLength(10)]
        public string Viscosity { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int PackageCapacity { get; set; }

        public ICollection<Lot> Lots { get; set; }
    }
}