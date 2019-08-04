using System;
using System.Collections.Generic;
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

        public string OilsUserId { get; set; }
        public OilsProUser OilsUser { get; set; }

        public string DeliveryAddressId { get; set; }
        public virtual DeliveryAddress DeliveryAddress { get; set; }

        public string CarrierId { get; set; }
        public virtual Carrier Carrier { get; set; }

        public string ReceiverId { get; set; }
        public virtual Receiver Receiver { get; set; }

        public string DriverId { get; set; }
        public virtual Driver Driver { get; set; }

        public string VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        public ICollection<OrderedProducts> Products { get; set; }
    }
}
