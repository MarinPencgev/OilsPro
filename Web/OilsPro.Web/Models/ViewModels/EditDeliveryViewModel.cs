using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OilsPro.Web.Models.ViewModels
{
    public class EditDeliveryViewModel
    {
        public string Id { get; set; }

        public string DeliveryDate { get; set; }

        public string SupplierName { get; set; }

        public string LotSerialNumber { get; set; }
    }
}
