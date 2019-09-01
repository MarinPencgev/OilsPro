using System.ComponentModel.DataAnnotations;

namespace OilsPro.Web.Models.ViewModels.Product
{
    public class IncludeProductViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Product  select is required!")]
        public string Product { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public string PackagesCount { get; set; }

        [Required]
        public string Lot { get; set; }
    }
}
