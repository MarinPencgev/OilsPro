using System.ComponentModel.DataAnnotations;

namespace OilsPro.Web.Models.ViewModels.Delivery
{
    public class CreateLotViewModel
    {
        [Required]
        [MaxLength(20)]
        public string SerialNumber { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int PackagesCount { get; set; }

        [Required]
        [Range(typeof(decimal), "0.0", "79228162514264337593543950335")]
        public decimal PackagesWeight { get; set; }

        [Required]
        [MaxLength(30)]
        public string ProductName { get; set; }
    }
}
