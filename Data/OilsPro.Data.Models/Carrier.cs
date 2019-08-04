using System.Collections.Generic;

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

        public string Name { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
        public ICollection<Driver> Drivers { get; set; }
    }
}
