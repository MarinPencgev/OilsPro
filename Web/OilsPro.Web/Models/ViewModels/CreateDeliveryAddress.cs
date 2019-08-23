using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace OilsPro.Web.Models.ViewModels
{
    public class CreateDeliveryAddress
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Town { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Street { get; set; }

        public string ReceiverName { get; set; }
    }
}
