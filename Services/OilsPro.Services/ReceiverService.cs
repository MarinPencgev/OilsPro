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
            if (id == null)
            {
                return new Receiver();
            }

            var receiver = _context.Receivers
                .Include(x => x.DeliveryAddresses)
                .First(x => x.Id == id);
            return receiver;
        }

        public ICollection<string> GetReceiverAddresses(string receiverName)
        {
            var addresses = _context.Receivers
                .Include(x => x.DeliveryAddresses)
                .FirstOrDefault(x => x.Name == receiverName)
                .DeliveryAddresses
                .Select(x => x.Town + ", " + x.Street)
                .ToList();
            return addresses;
        }

        public ICollection<DeliveryAddress> GetDeliveryAddressesByReceiverId(string id)
        {
            var addresses = _context.Receivers
                .Include(x => x.DeliveryAddresses)
                .First(x => x.Id == id)
                .DeliveryAddresses
                .ToList();

            return addresses;
        }

        public Receiver IncludeNewAddress(string receiverId, string town, string street)
        {
            var receiver = _context.Receivers
                .Include(x => x.DeliveryAddresses)
                .First(x => x.Id == receiverId);

            receiver.DeliveryAddresses.Add(new DeliveryAddress
            {
                Town = town,
                Street = street
            });

            _context.SaveChanges();

            return receiver;
        }

        public DeliveryAddress EditIncludedAddress(string inputId, string inputTown, string inputStreet)
        {
            var address = _context.DeliveryAddresses.Find(inputId);

            address.Town = inputTown;
            address.Street = inputStreet;

            _context.SaveChanges();

            return address;
        }

        public Receiver GetReceiverByAddressId(string inputId)
        {
            var address = _context.DeliveryAddresses.Find(inputId);
            var receiver = _context.Receivers
                .Include(x => x.DeliveryAddresses)
                .FirstOrDefault(x => x.DeliveryAddresses.Contains(address));

            return receiver;
        }

        public void ChangeName(string inputId, string inputName)
        {
            var receiver = _context.Receivers.Find(inputId);
            receiver.Name = inputName;

            _context.SaveChanges();
        }

        public Receiver Edit(Receiver receiver)
        {
            _context.Update(receiver);
            _context.SaveChanges();

            return receiver;
        }
    }
}
