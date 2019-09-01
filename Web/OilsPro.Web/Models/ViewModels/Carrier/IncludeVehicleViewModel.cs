using System.ComponentModel.DataAnnotations;

namespace OilsPro.Web.Models.ViewModels.Carrier
{
    public class IncludeVehicleViewModel
    {
        public string CarrierId { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string RegNumber { get; set; }

    }
}
