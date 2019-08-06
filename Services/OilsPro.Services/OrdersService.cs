using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OilsPro.Data;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly OilsProDbContext _context;

        public OrdersService(OilsProDbContext context)
        {
            _context = context;
        }

        public Order Create(string userId,
                            string purpose,
                            string deliveryAddress,
                            string receiverName,
                            string carrierName,
                            string driverName,
                            string vehicleNumber)
        {
            var town = deliveryAddress.Split(", ", StringSplitOptions.RemoveEmptyEntries)[0];
            var street = deliveryAddress.Split(", ", StringSplitOptions.RemoveEmptyEntries)[1];
            OrderPurpose deliveryPurpose = Enum.Parse<OrderPurpose>(purpose);
            DeliveryAddress address = _context.DeliveryAddresses.FirstOrDefault(x => x.Town == town && x.Street == street);
            Receiver receiver = _context.Receivers.FirstOrDefault(x => x.Name == receiverName);
            Carrier carrier = _context.Carriers.FirstOrDefault(x => x.Name == carrierName);
            Driver driver = _context.Drivers.FirstOrDefault(x => x.FullName == driverName && x.CarrierId == carrier.Id);
            Vehicle vehicle = _context.Vehicles.FirstOrDefault(x => x.RegNumber == vehicleNumber && x.CarrierId == carrier.Id);

            //int lastSequence = _context.Orders.Max(x => int.Parse(x.SequenceNumber));

            var order = new Order()
            {
                //SequenceNumber = (lastSequence + 1).ToString(),
                CreatedOn = DateTime.UtcNow,
                Purpose = deliveryPurpose,
                Status = OrderStatus.Uncompleted,
                OilsUserId = userId,
                DeliveryAddress = address,
                Receiver = receiver,
                Carrier = carrier,
                Driver = driver,
                Vehicle = vehicle
            };

            _context.Orders.Add(order);
            _context.SaveChanges();

            return order;
        }

        public Order GetOrderById(string id)
        {
            var order = _context.Orders
                .Include(x => x.OilsUser)
                .Include(x => x.DeliveryAddress)
                .Include(x => x.Receiver)
                .Include(x => x.Carrier)
                .Include(x => x.Driver)
                .Include(x => x.Vehicle)
                .Include(x => x.Products)
                .ThenInclude(x => x.Product)
                .SingleOrDefault(x => x.Id == id);
            return order;
        }


        public IQueryable<Order> GetAllUncomleted()
        {
            var uncomletedOrders = _context.Orders
                .Include(x => x.OilsUser)
                .Include(x => x.DeliveryAddress)
                .Include(x => x.Driver)
                .Include(x => x.Vehicle)
                .Include(x => x.Receiver)
                .Include(x => x.Carrier)
                .Include(x => x.Products)
                .ThenInclude(x => x.Product)
                .Where(x => x.Status == OrderStatus.Uncompleted && x.IsDeleted == false);

            return uncomletedOrders;
        }

        public ICollection<Vehicle> GetVehiclesByCarrierName(string name)
        {
            return _context.Vehicles.Where(x => x.Carrier.Name == name).ToList();
        }

        public ICollection<Driver> GetDriversByCarrierName(string name)
        {
            return _context.Drivers.Where(x => x.Carrier.Name == name).ToList();
        }

        public void Edit(int sequenceNumber,
                         string id,
                         DateTime createdOn,
                         OrderPurpose purpose,
                         OrderStatus status,
                         string deliveryAddress,
                         string receiverName,
                         string carrierName,
                         string driverName,
                         string vehicleRegNumber)
        {
            var order = _context.Orders
                .Include(x => x.OilsUser)
                .Include(x => x.DeliveryAddress)
                .Include(x => x.Driver)
                .Include(x => x.Vehicle)
                .Include(x => x.Receiver)
                .Include(x => x.Carrier)
                .Include(x => x.Products)
                .ThenInclude(x => x.Product)
                .FirstOrDefault(x => x.Id == id);

            var town = deliveryAddress.Split(", ")[0];
            var street = deliveryAddress.Split(", ")[1];

            order.CreatedOn = createdOn;
            order.Purpose = purpose;
            order.SequenceNumber = sequenceNumber;
            order.Status = status;
            order.DeliveryAddress.Town = town;
            order.DeliveryAddress.Street = street;
            order.Receiver.Name = receiverName;
            order.Carrier.Name = carrierName;
            order.Driver.FullName = driverName;
            order.Vehicle.RegNumber = vehicleRegNumber;

            _context.SaveChanges();
        }

        public Order Remove(string id)
        {
            var order = _context.Orders.First(x => x.Id == id);
            order.IsDeleted = true;

            _context.SaveChanges();

            return order;
        }

        public Order Release(string id)
        {
            var order = _context.Orders
                .Include(x => x.OilsUser)
                .Include(x => x.DeliveryAddress)
                .Include(x => x.Driver)
                .Include(x => x.Vehicle)
                .Include(x => x.Receiver)
                .Include(x => x.Carrier)
                .Include(x => x.Products)
                .ThenInclude(x => x.Product)
                .First(x => x.Id == id);
            order.Status = OrderStatus.Completed;
            order.ReleaseDate = DateTime.UtcNow;

            _context.SaveChanges();

            return order;
        }
    }

}
