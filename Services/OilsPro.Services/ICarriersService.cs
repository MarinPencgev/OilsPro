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
        Carrier GetCarrierById(string id);
        Carrier Edit(Carrier carrier);
        Carrier GetCarrierByVehicleId(string id);
        Carrier GetCarrierByDriverId(string id);
        Vehicle EditIncludedVehicle(string id, string regNumber);
        Driver EditIncludedDriver(string id, string fullName);
        Carrier IncludeNewVehicle(string carrierId, string regNumber);
        Carrier IncludeNewDriver(string carrierId, string fullName);
        Vehicle RemoveVehicle(string vehicleId);
        Driver RemoveDriver(string driverId);
        ICollection<Carrier> GetAllCarriers();
        Vehicle CreateNewVehicle(string regNumber, string carrierName);
        Driver CreateNewDriver(string fullName, string carrierName);
        Carrier Delete(string carrierId);
    }
}
