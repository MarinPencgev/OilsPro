using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OilsPro.Data.Models;

namespace OilsPro.Web.Models.ViewModels
{
    public class CreateOrderViewModel
    {
        public CreateOrderViewModel()
        {
            this.OrderedProducts = new List<OrderedProducts>();
        }
        public string Id { get; set; }

        public int SequenceNumber { get; set; }
        
        [Display(Name = "Creation date")]
        [DataType(DataType.Date)]    
        public DateTime CreatedOn { get; set; }

        public OrderPurpose Purpose { get; set; } = OrderPurpose.Consumption;

        public OrderStatus Status { get; set; } = OrderStatus.Uncompleted;

        [Required]
        public string DeliveryAddress { get; set; } 

        [Required]
        [Display(Name = "Receiver Name")]
        [DataType(DataType.Text)]
        public Receiver Receiver { get; set; }
        [Required]
        public Carrier Carrier { get; set; }
        [Required]
        public Vehicle Vehicle { get; set; }
        [Required]
        public Driver Driver { get; set; }

        public ICollection<OrderedProducts> OrderedProducts { get; set; }
    }
}
