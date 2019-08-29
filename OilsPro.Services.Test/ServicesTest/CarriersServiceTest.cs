using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OilsPro.Data.Models;
using OilsPro.Services.Test.Common;

namespace OilsPro.Services.Test.ServicesTest
{
    public class CarriersServiceTest
    {
        private ICarriersService carriersService;

        [Test]
        public void CreateNewDriver_works_Properly()
        {
            string errorMessagePrefix = "CarriersService CreateNewDriver() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.carriersService = new CarriersService(context);

            var carrier = new Carrier
            {
                Name = "Carrier1"
            };
            context.Carriers.Add(carrier);
            context.SaveChanges();

            var result = carriersService.CreateNewDriver("Driver1", carrier.Name);

            Assert.True(context.Drivers.Count()==1);
            Assert.True(context.Drivers.First().FullName == "Driver1");

        }

        [Test]
        public void CreateNewVehicle_works_Properly()
        {
            string errorMessagePrefix = "CarriersService CreateNewVehicle() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.carriersService = new CarriersService(context);

            var carrier = new Carrier
            {
                Name = "Carrier1"
            };
            context.Carriers.Add(carrier);
            context.SaveChanges();

            var result = carriersService.CreateNewVehicle("RegNumber1", carrier.Name);

            Assert.True(context.Vehicles.Count() == 1);
            Assert.True(context.Vehicles.First().RegNumber == "RegNumber1");
        }

        [Test]
        public void Delete_works_Properly()
        {
            string errorMessagePrefix = "CarriersService Delete() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.carriersService = new CarriersService(context);

            var carrier = new Carrier
            {
                Name = "Carrier1"
            };
            context.Carriers.Add(carrier);
            context.SaveChanges();

            var result = carriersService.Delete(carrier.Id);

            Assert.True(result.isDeleted);

        }

        [Test]
        public void EditIncludedDriver_works_Properly()
        {
            string errorMessagePrefix = "CarriersService EditIncludedDriver() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.carriersService = new CarriersService(context);

            var carrier = new Carrier
            {
                Name = "Carrier1",
                Drivers = new List<Driver>
                {
                    new Driver
                    {
                        FullName = "Driver1"
                    },
                }
            };
            context.Carriers.Add(carrier);
            context.SaveChanges();

            var driverId = context.Drivers.First().Id;

            var result = carriersService.EditIncludedDriver(driverId, "Driver2");

            Assert.True(context.Drivers.First().FullName == "Driver2");
        }

        [Test]
        public void EditIncludedVehicle_works_Properly()
        {
            string errorMessagePrefix = "CarriersService EditIncludedVehicle() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.carriersService = new CarriersService(context);

            var carrier = new Carrier
            {
                Name = "Carrier1",
                Vehicles = new List<Vehicle>
                {
                    new Vehicle()
                    {
                        RegNumber = "RegNumber1"
                    },
                }
            };
            context.Carriers.Add(carrier);
            context.SaveChanges();

            var vehicleId = context.Vehicles.First().Id;

            var result = carriersService.EditIncludedVehicle(vehicleId, "RegNumber2");

            Assert.True(context.Vehicles.First().RegNumber == "RegNumber2");
        }

        [Test]
        public void GetCarrierByDriverId_works_Properly()
        {
            string errorMessagePrefix = "CarriersService GetCarrierByDriverId() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.carriersService = new CarriersService(context);

            var carrier = new Carrier
            {
                Name = "Carrier1",
                Drivers = new List<Driver>
                {
                    new Driver
                    {
                        FullName = "Driver1"
                    },
                }
            };
            context.Carriers.Add(carrier);
            context.SaveChanges();

            var driverId = context.Drivers.First().Id;

            var result = carriersService.GetCarrierByDriverId(driverId);
            var expected = carrier;

            Assert.AreEqual(expected, result, errorMessagePrefix);
        }

        [Test]
        public void GetCarrierByVehicleId_works_Properly()
        {
            string errorMessagePrefix = "CarriersService GetCarrierByVehicleId() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.carriersService = new CarriersService(context);

            var carrier = new Carrier
            {
                Name = "Carrier1",
                Vehicles = new List<Vehicle>
                {
                    new Vehicle()
                    {
                        RegNumber = "RegNumber1"
                    },
                }
            };
            context.Carriers.Add(carrier);
            context.SaveChanges();

            var vehicleId = context.Vehicles.First().Id;

            var result = carriersService.GetCarrierByVehicleId(vehicleId);
            var expected = carrier;

            Assert.AreEqual(expected, result, errorMessagePrefix);
        }

        [Test]
        public void GetCarrierDrivers_works_Properly()
        {
            string errorMessagePrefix = "CarriersService GetCarrierDrivers() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.carriersService = new CarriersService(context);

            var carrier = new Carrier
            {
                Name = "Carrier1",
                Drivers = new List<Driver>
                {
                    new Driver
                    {
                        FullName = "Driver1"
                    },
                    new Driver
                    {
                        FullName = "Driver2"
                    },
                }
            };
            context.Carriers.Add(carrier);
            context.SaveChanges();

            var result = carriersService.GetCarrierDrivers(carrier.Name);

            Assert.True(result.Count == 2);
        }

        [Test]
        public void GetCarrierVehicles_works_Properly()
        {
            string errorMessagePrefix = "CarriersService GetCarrierDrivers() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.carriersService = new CarriersService(context);

            var carrier = new Carrier
            {
                Name = "Carrier1",
                Vehicles = new List<Vehicle>
                {
                    new Vehicle()
                    {
                        RegNumber = "RegNumber1"
                    },
                    new Vehicle()
                    {
                        RegNumber = "RegNumber2"
                    },
                }
            };
            context.Carriers.Add(carrier);
            context.SaveChanges();

            var result = carriersService.GetCarrierVehicles(carrier.Name);

            Assert.True(result.Count == 2);
        }

        [Test]
        public void RemoveDriver_works_Properly()
        {
            string errorMessagePrefix = "CarriersService RemoveDriver() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.carriersService = new CarriersService(context);

            var driver = new Driver
            {
                FullName = "Driver1"
            };

            context.Drivers.Add(driver);
            context.SaveChanges();

            var result = carriersService.RemoveDriver(driver.Id);

            Assert.True(result.isDeleted);
        }

        [Test]
        public void RemoveVehicle_works_Properly()
        {
            string errorMessagePrefix = "CarriersService RemoveDriver() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.carriersService = new CarriersService(context);

            var vehicle = new Vehicle
            {
                RegNumber = "RegNumber1"
            };

            context.Vehicles.Add(vehicle);
            context.SaveChanges();

            var result = carriersService.RemoveVehicle(vehicle.Id);

            Assert.True(result.isDeleted);
        }
    }
}
