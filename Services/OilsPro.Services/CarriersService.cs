using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OilsPro.Data;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public class CarriersService : ICarriersService
    {
        private readonly OilsProDbContext _context;

        public CarriersService(OilsProDbContext context)
        {
            _context = context;
        }
        public ICollection<string> GetCarrierVehicles(string carrierName)
        {
            var vehicles = _context.Vehicles
                .Where(x => x.Carrier.Name == carrierName)
                .Select(x => x.RegNumber)
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
                .Include(x => x.Carrier)
                .Where(x => x.Carrier.Id == id)
                .ToList();

            return vehicles;
        }

        public ICollection<Driver> GetDriversByCarrierId(string id)
        {
            var drivers = _context.Drivers
                .Include(x => x.Carrier)
                .Where(x => x.Carrier.Id == id)
                .ToList();

            return drivers;
        }

        public Carrier GetCarrierById(string id)
        {
            if (id == null)
            {
                return new Carrier();
            }

            var carrier = _context.Carriers.Find(id);

            return carrier;
        }

        public Carrier Edit(Carrier carrier)
        {
            _context.Update(carrier);
            _context.SaveChanges();

            return carrier;
        }

        public Carrier GetCarrierByVehicleId(string id)
        {
            var vehicle = _context.Vehicles.Find(id);
            var carrier = _context.Carriers
                .Include(x => x.Vehicles)
                .FirstOrDefault(x => x.Vehicles.Contains(vehicle));
            return carrier;
        }

        public Carrier GetCarrierByDriverId(string id)
        {
            var driver = _context.Drivers.Find(id);
            var carrier = _context.Carriers
                .Include(x => x.Drivers)
                .FirstOrDefault(x => x.Drivers.Contains(driver));
            return carrier;
        }

        public Vehicle EditIncludedVehicle(string id, string regNumber)
        {
            var vehicle = _context.Vehicles.Find(id);
            vehicle.RegNumber = regNumber;

            _context.Update(vehicle);
            _context.SaveChanges();

            return vehicle;
        }

        public Driver EditIncludedDriver(string id, string fullName)
        {
            var driver = _context.Drivers.Find(id);
            driver.FullName = fullName;

            _context.Update(driver);
            _context.SaveChanges();

            return driver;
        }

        public Carrier IncludeNewVehicle(string carrierId, string regNumber)
        {
            var carrier = _context.Carriers
                .Include(x => x.Vehicles)
                .First(x => x.Id == carrierId);
            carrier.Vehicles.Add(new Vehicle
            {
                RegNumber = regNumber,
            });

            _context.SaveChanges();

            return carrier;
        }

        public Carrier IncludeNewDriver(string carrierId, string fullName)
        {
            var carrier = _context.Carriers
                .Include(x => x.Drivers)
                .First(x => x.Id == carrierId);
            carrier.Drivers.Add(new Driver
            {
                FullName = fullName,
            });

            _context.SaveChanges();

            return carrier;
        }

        public Carrier RemoveVehicle(string id)
        {
            var vehicle = _context.Vehicles.Find(id);

            var carrier = _context.Carriers.FirstOrDefault(x => x.Vehicles.Contains(vehicle));

            _context.Remove(vehicle);
            _context.SaveChanges();

            return carrier;
        }

        public Carrier RemoveDriver(string id)
        {
            var driver = _context.Drivers.Find(id);

            var carrier = _context.Carriers.FirstOrDefault(x => x.Drivers.Contains(driver));

            _context.Remove(driver);
            _context.SaveChanges();

            return carrier;
        }

        public ICollection<Carrier> GetAllCarriers()
        {
            var carriers = _context.Carriers
                .Include(x => x.Drivers)
                .Include(x => x.Vehicles)
                .ToList();

            return carriers;
        }

        public Vehicle CreateNewVehicle(string regNumber, string carrierName)
        {
            var carrier = _context.Carriers
                .Include(x=>x.Vehicles)
                .Include(x=>x.Drivers)
                .FirstOrDefault(x => x.Name == carrierName);

            var vehicle = new Vehicle
            {
                RegNumber = regNumber,
                CarrierId = carrier.Id,
            };

            if (carrier.Vehicles.Any(x => x.RegNumber == regNumber))
            {
                //TODO message if contains vehicle
                throw new ArgumentException("there are.......");
            }

            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();

            return vehicle;
        }

        public Driver CreateNewDriver(string fullName, string carrierName)
        {
            var carrier = _context.Carriers
                .Include(x => x.Vehicles)
                .Include(x => x.Drivers)
                .FirstOrDefault(x => x.Name == carrierName);

            var driver = new Driver()
            {
                FullName = fullName,
                CarrierId = carrier.Id,
            };

            if (carrier.Drivers.Any(x => x.FullName == fullName))
            {
                //TODO message if contains driver
                throw new ArgumentException("there are.......");
            }

            _context.Drivers.Add(driver);
            _context.SaveChanges();

            return driver;
        }
    }
}
