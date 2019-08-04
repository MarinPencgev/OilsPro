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

        IQueryable<Order> GetAllUncomleted();

        ICollection<Vehicle> GetVehiclesByCarrierName(string name);
        ICollection<Driver> GetDriversByCarrierName(string name);
        void Edit(int sequenceNumber,
                  string id,
                  DateTime createdOn,
                  OrderPurpose purpose,
                  OrderStatus status,
                  string deliveryAddress,
                  string receiverName,
                  string carrierName,
                  string driverName,
                  string vehicleRegNumber);
        Order Remove(string id);
        Order Release(string id);
    }
}
