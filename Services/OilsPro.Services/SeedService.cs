using System;
using System.Collections.Generic;
using System.Linq;
using OilsPro.Data;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public class SeedService : IDataSeeder
    {
        private readonly OilsProDbContext _context;

        public SeedService(OilsProDbContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            for (int i = 1; i < 10; i++)
            {
                this._context.Products.Add(new Product()
                {
                    Name = $"Oil{i}",
                    ProductCode = $"0101010{i}",
                    PackageCapacity = 205,
                    Viscosity = $"{i * 5}/40",
                    Lots = new List<Lot>
                    {
                        new Lot()
                        {
                            SerialNumber = $"12{i*10}/121212",
                            PackagesCount = 20 + i,
                            PackagesWeight = 3700,
                            Density = 0.905m,
                        }
                    },
                    
                });
            }

            for (int i = 1; i < 10; i++)
            {
                this._context.Receivers.Add(new Receiver()
                {
                    
                    Name = $"Receiver{i}",
                    DeliveryAddresses = new List<DeliveryAddress>()
                    {
                        new DeliveryAddress
                        {
                            Town = $"Town{i}",
                            Street = $"Street {i})"
                        },
                        new DeliveryAddress
                        {
                            Town = $"Town{i + 1}",
                            Street = $"Street ({i + 1})",
                        },
                        new DeliveryAddress
                        {
                            Town = $"Town{i + 2}",
                            Street = $"Street ({i + 2})",
                        },
                    },
                    Orders = new List<Order>()
                });
            }

            for (int i = 1; i < 10; i++)
            {
                this._context.Carriers.Add(new Carrier()
                {
                    Name = $"Carrier{i}",
                    Drivers = new List<Driver>()
                    {
                        new Driver
                        {
                            FullName = $"Driver Driverov {i}",
                            
                        },
                        new Driver
                        {
                            FullName = $"Driver Driverov {i + 1}",

                        },
                        new Driver
                        {
                            FullName = $"Driver Driverov {i + 2}"

                        }

                    },
                    Vehicles = new List<Vehicle>()
                    {
                        new Vehicle
                        {
                            RegNumber = $"PB{i}{i}{i}{i}AH"
                        },
                        new Vehicle
                        {
                            RegNumber = $"PB{i+1}{i+1}{i+1}{i+1}AH"
                        },
                        new Vehicle
                        {
                            RegNumber = $"PB{i+2}{i+2}{i+2}{i+2}AH"
                        },
                    },

                });
            }
            
            _context.SaveChanges();

           // OrderSeeding();
        }

        public void OrderSeeding()
        {
            for (int i = 3; i < 7; i++)
            {
                this._context.Orders.Add(new Order()
                {
                    SequenceNumber = ++i,
                    CreatedOn = DateTime.Now,
                    Purpose = OrderPurpose.Consumption,
                    Status = OrderStatus.Uncompleted,

                    DeliveryAddress = this._context.DeliveryAddresses.Last(),
                    Receiver = this._context.Receivers.Last(),
                    Carrier = this._context.Carriers.First(),
                    Driver = this._context.Drivers.Last(),
                    Vehicle = this._context.Vehicles.First(),
                    Products = new List<OrderedProducts>
                    {
                       new OrderedProducts
                       {
                           Product = this._context.Products.First(),
                           OrderedPackagesCount = i * 10,
                           OrderedPackagesWeight = i * 10 * 0.85m,
                       },
                       new OrderedProducts
                       {
                           Product = this._context.Products.Last(),
                           OrderedPackagesCount = i * 20,
                           OrderedPackagesWeight = i * 20 * 0.91m,
                       },
                    }

                });
            }
            _context.SaveChanges();
        }
    }
}
