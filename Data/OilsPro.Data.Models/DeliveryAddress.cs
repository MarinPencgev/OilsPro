using System.ComponentModel.DataAnnotations;

namespace OilsPro.Data.Models
{
    public class DeliveryAddress
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Town { get; set; }

        [Required]
        [MaxLength(50)]
        public string Street { get; set; }

        [Required]
        public string ReceiverId { get; set; }
        public Receiver Receiver { get; set; }
    }
}
