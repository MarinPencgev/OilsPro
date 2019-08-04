using System.Collections;
using System.Linq;
using AutoMapper;
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

        public ICollection All(string entityType)
        {
            switch (entityType)
            {
                case "Products":
                    return _context.Products.ToList();
                case "Receivers":
                    return _context.Receivers.ToList();
                case "Carriers":
                    return _context.Carriers.ToList();
                case "Vehicles":
                    return _context.Vehicles.ToList();
                case "Drivers":
                    return _context.Drivers.ToList();
                case "Addresses":
                    return _context.DeliveryAddresses.ToList();
            }

            return null;
        }
    }
}
