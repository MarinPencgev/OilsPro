﻿using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using AutoMapper;
using AutoMapper.Execution;
using Microsoft.EntityFrameworkCore;
using OilsPro.Data;

namespace OilsPro.Services
{
    public class NomenclaturesServices : INomenclaturesService
    {
        private readonly OilsProDbContext _context;
        private readonly IMapper _mapper;

        public NomenclaturesServices(OilsProDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public int GetRecordings(string entityName)
        {
            var recordings = 0;
            switch (entityName)
            {
                case "Products":
                    recordings = _context.Products.Count();
                    break;
                case "Receivers":
                    recordings = _context.Receivers.Count();
                    break;
                case "Carriers":
                    recordings = _context.Carriers.Count();
                    break;
                case "Vehicles":
                    recordings = _context.Vehicles.Count();
                    break;
                case "Drivers":
                    recordings = _context.Drivers.Count();
                    break;
                case "Addresses":
                    recordings = _context.DeliveryAddresses.Count();
                    break;
            }

            return recordings;
        }

        public ICollection All(string entityName)
        {
            switch (entityName)
            {
                case "Products":
                    return _context.Products
                        .Where(x => x.isDeleted == false)
                        .Include(x=>x.Lots)
                        .ToList();
                case "Receivers":
                    return _context.Receivers
                        .Where(x => x.isDeleted == false)
                        .Include(x=>x.DeliveryAddresses)
                        .Include(x=>x.Orders)
                        .ToList();
                case "Carriers":
                    return _context.Carriers
                        .Where(x=>x.isDeleted == false)
                        .Include(x=>x.Drivers)
                        .Include(x=>x.Vehicles)
                        .ToList();
                case "Vehicles":
                    return _context.Vehicles
                        .Where(x => x.isDeleted == false)
                        .Include(x=>x.Carrier)
                        .ToList();
                case "Drivers":
                    return _context.Drivers
                        .Where(x => x.isDeleted == false)
                        .Include(x => x.Carrier)
                        .ToList();
                case "Addresses":
                    return _context.DeliveryAddresses
                        .Where(x => x.isDeleted == false)
                        .Include(x=>x.Receiver)
                        .ToList();
            }
            return null;
        }
    }
}
