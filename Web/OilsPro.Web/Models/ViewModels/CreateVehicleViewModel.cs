using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OilsPro.Web.Models.ViewModels
{
    public class CreateVehicleViewModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string RegNumber { get; set; }

        [Required]
        public string CarrierName { get; set; }
    }
}
