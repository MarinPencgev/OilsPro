using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OilsPro.Web.Models.ViewModels
{
    public class IncludeProductViewModel
    {
        public string OrderId { get; set; }

        public string Product { get; set; }

        public string Lot { get; set; }

        public string Quantity { get; set; }
    }
}
