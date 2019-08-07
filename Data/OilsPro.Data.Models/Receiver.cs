using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OilsPro.Data.Models
{
    public class Receiver
    {
        public Receiver()
        {
            this.DeliveryAddresses = new List<DeliveryAddress>();
            this.Orders = new List<Order>();
        }
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<DeliveryAddress> DeliveryAddresses { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
