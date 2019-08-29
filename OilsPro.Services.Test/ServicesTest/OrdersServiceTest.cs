using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OilsPro.Data.Models;
using OilsPro.Services.Test.Common;

namespace OilsPro.Services.Test.ServicesTest
{

    public class OrdersServiceTest
    {
        private IOrdersService ordersService;

        [Test]
        public void Create_works_Properly()
        {
            string errorMessagePrefix = "OrdersService Create() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.ordersService = new OrdersService(context);

            var receiver = new Receiver
            {
                Name = "Receiver1"
            };
            context.Receivers.Add(receiver);

            var carrier = new Carrier
            {
                Name = "Carrier1"
            };
            context.Carriers.Add(carrier);

            var driver = new Driver
            {
                FullName = "Driver1"
            };
            context.Drivers.Add(driver);

            var vehicle = new Vehicle
            {
                RegNumber = "RegNumber1"
            };
            context.Vehicles.Add(vehicle);

            context.SaveChanges();

            var result = ordersService.Create("UserId", "Ropa", "Town1, Street1", "Receiver1", "Carrier1", "Driver1",
                "RegNumber1");

            var expected = context.Orders.First();

            Assert.AreEqual(expected, result, errorMessagePrefix);
        }

        [Test]
        public void Release_works_Properly()
        {
            string errorMessagePrefix = "OrdersService Release() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.ordersService = new OrdersService(context);

            var receiver = new Receiver
            {
                Name = "Receiver1"
            };
            context.Receivers.Add(receiver);
            var carrier = new Carrier
            {
                Name = "Carrier1"
            };
            context.Carriers.Add(carrier);

            var driver = new Driver
            {
                FullName = "Driver1"
            };
            context.Drivers.Add(driver);

            var vehicle = new Vehicle
            {
                RegNumber = "RegNumber1"
            };
            context.Vehicles.Add(vehicle);

            var address = new DeliveryAddress()
            {
                Town = "Town1",
                Street = "Street1"
            };
            context.DeliveryAddresses.Add(address);

            context.SaveChanges();

            var order = ordersService.Create("UserId", "Ropa", "Town1, Street1", "Receiver1", "Carrier1", "Driver1",
                "RegNumber1");


            var result = ordersService.Release(order.Id);
            
            Assert.True(result.Status == OrderStatus.Completed);
            Assert.True(result.ReleaseDate != null);
        }

        [Test]
        public void Remove_works_Properly()
        {
            string errorMessagePrefix = "OrdersService Remove() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.ordersService = new OrdersService(context);
            var receiver = new Receiver
            {
                Name = "Receiver1"
            };
            context.Receivers.Add(receiver);
            var carrier = new Carrier
            {
                Name = "Carrier1"
            };
            context.Carriers.Add(carrier);

            var driver = new Driver
            {
                FullName = "Driver1"
            };
            context.Drivers.Add(driver);

            var vehicle = new Vehicle
            {
                RegNumber = "RegNumber1"
            };
            context.Vehicles.Add(vehicle);

            var address = new DeliveryAddress()
            {
                Town = "Town1",
                Street = "Street1"
            };
            context.DeliveryAddresses.Add(address);

            context.SaveChanges();

            var order = ordersService.Create("UserId", "Ropa", "Town1, Street1", "Receiver1", "Carrier1", "Driver1",
                "RegNumber1");

            var result = ordersService.Remove(order.Id);

            Assert.True(context.Orders.Any());
        }

        [Test]
        public void GetDriversByCarrierName_works_Properly()
        {
            string errorMessagePrefix = "OrdersService GetDriversByCarrierName() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.ordersService = new OrdersService(context);

            var receiver = new Receiver
            {
                Name = "Receiver1"
            };
            context.Receivers.Add(receiver);

            var carrier = new Carrier
            {
                Name = "Carrier1",
                Drivers = new List<Driver>()
                {
                    new Driver()
                    {
                        FullName = "Driver1"
                    }
                },
                Vehicles = new List<Vehicle>
                {
                    new Vehicle()
                    {
                        RegNumber = "RegNumber1"
                    }
                }
            };
            context.Carriers.Add(carrier);

            var address = new DeliveryAddress()
            {
                Town = "Town1",
                Street = "Street1"
            };
            context.DeliveryAddresses.Add(address);

            context.SaveChanges();

            var order = ordersService.Create("UserId", "Ropa", "Town1, Street1", "Receiver1", "Carrier1", "Driver1",
                "RegNumber1");

            var result = ordersService.GetDriversByCarrierName("Carrier1").First().FullName;
            var expected = "Driver1";

            Assert.AreEqual(expected, result, errorMessagePrefix);
        }

        [Test]
        public void GetVehiclesByCarrierName_works_Properly()
        {
            string errorMessagePrefix = "OrdersService GetVehiclesByCarrierName() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.ordersService = new OrdersService(context);

            var receiver = new Receiver
            {
                Name = "Receiver1"
            };
            context.Receivers.Add(receiver);

            var carrier = new Carrier
            {
                Name = "Carrier1",
                Drivers = new List<Driver>()
                {
                    new Driver()
                    {
                        FullName = "Driver1"
                    }
                },
                Vehicles = new List<Vehicle>
                {
                    new Vehicle()
                    {
                        RegNumber = "RegNumber1"
                    }
                }
            };
            context.Carriers.Add(carrier);

            var address = new DeliveryAddress()
            {
                Town = "Town1",
                Street = "Street1"
            };
            context.DeliveryAddresses.Add(address);

            context.SaveChanges();

            var order = ordersService.Create("UserId", "Ropa", "Town1, Street1", "Receiver1", "Carrier1", "Driver1",
                "RegNumber1");

            var result = ordersService.GetVehiclesByCarrierName("Carrier1").First().RegNumber;
            var expected = "RegNumber1";

            Assert.AreEqual(expected, result, errorMessagePrefix);
        }
    }
}
