using System.ComponentModel.DataAnnotations;

namespace OilsPro.Web.Models.ViewModels.Receiver
{
    public class EditAddressViewModel
    {
        public string Id { get; set; }

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
