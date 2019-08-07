using System.ComponentModel.DataAnnotations;

namespace OilsPro.Data.Models
{
    public class Lot
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string SerialNumber { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int PackagesCount { get; set; }

        [Required]
        [Range(typeof(decimal), "0.0", "79228162514264337593543950335")]
        public decimal PackagesWeight{ get; set; }

        [Required]
        [Range(typeof(decimal), "0.7", "1.0")]
        public decimal Density { get; set; }

        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}