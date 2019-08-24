using System.ComponentModel.DataAnnotations;

namespace OilsPro.Data.Models
{
    public class Driver
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        public bool isDeleted { get; set; }

        public string CarrierId { get; set; }
        public Carrier Carrier { get; set; }
    }
}
