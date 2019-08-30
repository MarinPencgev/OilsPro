using System.ComponentModel.DataAnnotations;

namespace OilsPro.Web.Models.ViewModels
{
    public class CreateDeliveryAddress
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Town { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Street { get; set; }

        public string ReceiverName { get; set; }
    }
}
