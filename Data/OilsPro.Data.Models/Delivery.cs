using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OilsPro.Data.Models
{
    public class Delivery
    {
        public string Id { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        [Required]
        public string SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        [Required]
        public string LotId { get; set; }
        public Lot Lot { get; set; }
    }
}
