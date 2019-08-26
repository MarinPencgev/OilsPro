using System;
using System.Collections.Generic;
using System.Text;

namespace OilsPro.Data.Models
{
    public class DeliveredProduct
    {
        public string ProductId { get; set; }
        public Product Product { get; set; }

        public string LotId { get; set; }
        public Lot Lot { get; set; }

        public int DeliveredPackagesCount { get; set; }

        public decimal DeliveredPackagesWeight 
            => DeliveredPackagesCount * Product.PackageCapacity * Lot.Density;
    }
}
