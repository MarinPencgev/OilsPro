using System.ComponentModel.DataAnnotations;

namespace OilsPro.Data.Models
{
    public class DeliveryAddress
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Town { get; set; }

        [Required]
        [MaxLength(30)]
        public string Street { get; set; }

        public bool isDeleted { get; set; }

        [Required]
        public string ReceiverId { get; set; }
        public Receiver Receiver { get; set; }
    }
}
