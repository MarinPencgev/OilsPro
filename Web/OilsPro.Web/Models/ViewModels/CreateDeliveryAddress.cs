using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace OilsPro.Web.Models.ViewModels
{
    public class CreateDeliveryAddress
    {
        public string Town { get; set; }
        public string Street { get; set; }
        public string ReceiverName { get; set; }
    }
}
