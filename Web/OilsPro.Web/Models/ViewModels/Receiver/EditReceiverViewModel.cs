using System.ComponentModel.DataAnnotations;

namespace OilsPro.Web.Models.ViewModels.Receiver
{
    public class EditReceiverViewModel
    {
        public string Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

    }
}
