using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OilsPro.Web.Models.ViewModels
{
    public class IncludeProductViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Product  select is required!")]
        public string Product { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public string PackagesCount { get; set; }

        [Required]
        public string Lot { get; set; }
    }
}
