using System.ComponentModel.DataAnnotations;

namespace OilsPro.Web.Models.ViewModels.Carrier
{
    public class EditDriverViewModel
    {
        public string Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string FullName { get; set; }
    }
}
