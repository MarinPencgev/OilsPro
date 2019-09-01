using System.ComponentModel.DataAnnotations;

namespace OilsPro.Web.Models.ViewModels.Supplier
{
    public class CreateSupplierViewModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
