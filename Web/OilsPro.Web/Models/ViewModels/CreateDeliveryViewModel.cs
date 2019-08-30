using System;
using System.ComponentModel.DataAnnotations;

namespace OilsPro.Web.Models.ViewModels
{
    public class CreateDeliveryViewModel
    {
        public DateTime DeliveryDate { get; set; }

        [Required]
        [MaxLength(30)]
        public string SupplierName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LotSerialNumber { get; set; }
    }
}
