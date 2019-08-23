using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OilsPro.Data.Models
{
    public class Order
    {
        public Order()
        {
            this.Products = new List<OrderedProducts>();
        }
        public string Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SequenceNumber { get; set; } 

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime? ReleaseDate { get; set; } = null;

        public bool IsDeleted { get; set; }

        public OrderPurpose Purpose { get; set; } = OrderPurpose.Consumption;

        public OrderStatus Status { get; set; } = OrderStatus.Uncompleted;

        [Required]
        public string OilsUserId { get; set; }
        public OilsProUser OilsUser { get; set; }

        [Required]
        public string DeliveryAddressId { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }

        [Required]
        public string ReceiverId { get; set; }
        public Receiver Receiver { get; set; }

        public string CarrierId { get; set; }
        public Carrier Carrier { get; set; }

        public string DriverId { get; set; }
        public Driver Driver { get; set; }

        public string VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public ICollection<OrderedProducts> Products { get; set; }
    }
}
