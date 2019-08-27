using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Text;

namespace OilsPro.Data.Models
{
    public class Supplier
    {
        public Supplier()
        {
            this.Deliveries = new List<Delivery>();
        }
        public string Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public bool isDeleted { get; set; }

       

        public ICollection<Delivery> Deliveries { get; set; }

    }
}
