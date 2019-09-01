using System.ComponentModel.DataAnnotations;

namespace OilsPro.Web.Models.ViewModels.Carrier
{
    public class CreateVehicleViewModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string RegNumber { get; set; }

        [Required]
        public string CarrierName { get; set; }
    }
}
