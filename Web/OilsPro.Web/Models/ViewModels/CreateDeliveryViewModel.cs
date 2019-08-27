using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OilsPro.Web.Models.ViewModels
{
    public class CreateDeliveryViewModel
    {
        public DateTime DeliveryDate { get; set; }

        public string SupplierName { get; set; }

        public string LotSerialNumber { get; set; }
    }
}
