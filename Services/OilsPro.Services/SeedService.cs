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
                            SerialNumber = $"12{i*10}/12",
                            PackagesCount = 20 + i,
                            PackagesWeight = 3700,
                            Density = 0.905m,

                        },
                        new Lot()
                        {
                            SerialNumber = $"55{i*20}/55",
                            PackagesCount = 20 + i,
                            PackagesWeight = 3700,
                            Density = 0.8875m,

                        },
                        new Lot()
                        {
                            SerialNumber = $"88{i*30}/88",
                            PackagesCount = 20 + i,
                            PackagesWeight = 3700,
                            Density = 0.814m,

                        },
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
                            Town = $"Town-1 Receiver{i}",
                            Street = $"Street-1 Receiver{i}"
                        },
                        new DeliveryAddress
                        {
                            Town = $"Town-2 Receiver{i}",
                            Street = $"Street-2 Receiver{i}",
                        },
                        new DeliveryAddress
                        {
                            Town = $"Town-3 Receiver{i}",
                            Street = $"Street-3 Receiver{i}",
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
                            FullName = $"Driver-1 Carrier{i}",

                        },
                        new Driver
                        {
                            FullName = $"Driver-2 Carrier{i}",

                        },
                        new Driver
                        {
                            FullName = $"Driver-3 Carrier{i}"

                        }

                    },
                    Vehicles = new List<Vehicle>()
                    {
                        new Vehicle
                        {
                            RegNumber = $"PB{i}{i}{i}{i}AH Carrier{i}"
                        },
                        new Vehicle
                        {
                            RegNumber = $"PB{i+1}{i+1}{i+1}{i+1}AH Carrier{i}"
                        },
                        new Vehicle
                        {
                            RegNumber = $"PB{i+2}{i+2}{i+2}{i+2}AH Carrier{i}"
                        },
                    },

                });
            }

            for (int i = 1; i < 10; i++)
            {
                this._context.Suppliers.Add(new Supplier
                {
                    Name = $"Supplier{i}",
                    
                });
            }
            _context.SaveChanges();
        }
    }
}
