using System;
using System.Collections.Generic;
using System.Text;

namespace OilsPro.Data.Models
{
    public class Delivery
    {
        public string Id { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string SupierId { get; set; }
        public Supplier Supplier { get; set; }

        public string LotId { get; set; }
        public Lot Lot { get; set; }
    }
}
