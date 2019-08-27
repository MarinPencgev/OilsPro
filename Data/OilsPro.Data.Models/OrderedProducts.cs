using System.ComponentModel.DataAnnotations;

namespace OilsPro.Data.Models
{
    public class OrderedProducts
    {
        [Key]
        public string OrderId { get; set; }
        public Order Order { get; set; }

        [Key]
        public string ProductId { get; set; }
        public Product Product { get; set; }

        [Key]
        public string LotId { get; set; }
        public Lot Lot { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int OrderedPackagesCount { get; set; }

        [Required]
        [Range(typeof(decimal), "0.0", "79228162514264337593543950335")]
        public decimal OrderedPackagesWeight { get; set; }
    }
}
