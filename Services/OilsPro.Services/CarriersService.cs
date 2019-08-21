using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OilsPro.Data;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public class CarriersService:ICarriersService
    {
        private readonly OilsProDbContext _context;

        public CarriersService(OilsProDbContext context)
        {
            _context = context;
        }
        public ICollection<string> GetCarrierVehicles(string carrierName)
        {
            var vehicles = _context.Vehicles
                .Where(x=>x.Carrier.Name == carrierName)
                .Select(x =>x.RegNumber)
                .ToList();

            return vehicles;
        }

        public ICollection<string> GetCarrierDrivers(string carrierName)
        {
            var drivers = _context.Drivers
                .Where(x => x.Carrier.Name == carrierName)
                .Select(x => x.FullName)
                .ToList();

            return drivers;
        }

        public ICollection<Vehicle> GetVehiclesByCarrierId(string id)
        {
            var vehicles = _context.Vehicles
                .Where(x => x.Carrier.Id == id)
                .ToList();

            return vehicles;
        }

        public ICollection<Driver> GetDriversByCarrierId(string id)
        {
            var drivers = _context.Drivers
                .Where(x => x.Carrier.Id == id)
                .ToList();

            return drivers;
        }

        public Carrier GetCarrierById(string id)
        {
            var carrier = _context.Carriers.Find(id);
            return carrier;
        }

        public Carrier Edit(Carrier carrier)
        {
            _context.Update(carrier);
            _context.SaveChanges();

            return carrier;
        }
    }
}
