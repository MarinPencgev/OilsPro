using System;
using System.Collections.Generic;
using System.Text;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public interface ICarriersService
    {
        ICollection<string> GetCarrierVehicles(string carrierName);
        ICollection<string> GetCarrierDrivers(string carrierName);
        ICollection<Vehicle> GetVehiclesByCarrierId(string id);
        ICollection<Driver> GetDriversByCarrierId(string id);
    }
}
