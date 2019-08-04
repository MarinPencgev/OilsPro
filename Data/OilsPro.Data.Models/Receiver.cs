using System.Collections.Generic;

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

        public string Name { get; set; }

        public ICollection<DeliveryAddress> DeliveryAddresses { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
