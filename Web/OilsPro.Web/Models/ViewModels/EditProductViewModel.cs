using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OilsPro.Web.Models.ViewModels
{
    public class EditProductViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string ProductCode { get; set; }

        public string Viscosity { get; set; }

        public int PackageCapacity { get; set; }

    }
}
