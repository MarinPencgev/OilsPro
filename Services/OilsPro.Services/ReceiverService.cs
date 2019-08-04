using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OilsPro.Data;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public class ReceiverService : IReceiverService
    {
        private readonly OilsProDbContext _context;

        public ReceiverService(OilsProDbContext context)
        {
            _context = context;
        }
        public Receiver GetReceiverById(string id)
        {
            var receiver = _context.Receivers.First(x => x.Id == id);
            return receiver;
        }

        public ICollection<string> GetReceiverAddresses(string receiverName)
        {
            var addresses = _context.Receivers
                .Include(x => x.DeliveryAddresses)
                .FirstOrDefault(x => x.Name == receiverName)
                .DeliveryAddresses
                .Select(x=>x.Town + ", " + x.Street)
                .ToList();
            return addresses;
        }

    }
}
