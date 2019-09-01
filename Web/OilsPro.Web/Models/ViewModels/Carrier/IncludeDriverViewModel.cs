using System.ComponentModel.DataAnnotations;

namespace OilsPro.Web.Models.ViewModels.Carrier
{
    public class IncludeDriverViewModel
    {
        public string CarrierId { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string FullName { get; set; }
    }
}
