using System.ComponentModel.DataAnnotations;

namespace OilsPro.Web.Models.ViewModels.Receiver
{
    public class IncludeAddressViewModel
    {
        public string ReceiverId { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Town { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Street { get; set; }
    }
}
