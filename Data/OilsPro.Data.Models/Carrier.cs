using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OilsPro.Data.Models
{
    public class Carrier
    {
        public Carrier()
        {
            this.Vehicles = new List<Vehicle>();
            this.Drivers = new List<Driver>();
        }
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
        public ICollection<Driver> Drivers { get; set; }
    }
}
