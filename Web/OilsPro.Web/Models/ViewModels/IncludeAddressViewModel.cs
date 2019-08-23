using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OilsPro.Web.Models.ViewModels
{
    public class IncludeAddressViewModel
    {
        public string ReceiverId { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Town { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Street { get; set; }
    }
}
