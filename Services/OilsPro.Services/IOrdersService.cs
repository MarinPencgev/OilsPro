using System;
using System.Collections.Generic;
using System.Linq;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public interface IOrdersService
    {
        Order Create(string userId,
                    string purpose,
                    string deliveryAddress, 
                    string receiverName, 
                    string carrierName, 
                    string driverName,
                    string vehicleNumber);
        Order GetOrderById(string id);

        IQueryable<Order> GetAllUncompleted();

        ICollection<Vehicle> GetVehiclesByCarrierName(string name);
        ICollection<Driver> GetDriversByCarrierName(string name);

        Order Remove(string id);
        Order Release(string id);
        ICollection<Order> GetAllCompleted();
    }
}
