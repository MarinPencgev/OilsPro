using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OilsPro.Data;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public class DeliveriesService : IDeliveriesService
    {
        private readonly OilsProDbContext _context;

        public DeliveriesService(OilsProDbContext context)
        {
            _context = context;
        }
        public ICollection<Delivery> GetAll()
        {
            var deliveies = _context.Deliveries
                .Include(x => x.Supplier)
                .Include(x => x.Lot)
                .ToList();

            return deliveies;
        }

        public ICollection<Lot> GetAllLots()
        {
            var lots = _context.Lots

                .ToList();

            return lots;
        }

        public Delivery Create(string deliveryDate, string supplierName, string serialNumber)
        {
            var supplier = _context.Suppliers.SingleOrDefault(x => x.Name == supplierName);
            var lot = _context.Lots.SingleOrDefault(x => x.SerialNumber == serialNumber);

            var delivery = new Delivery
            {
                DeliveryDate = DateTime.Parse(deliveryDate),
                Supplier = supplier,
                Lot = lot,
            };

            _context.Deliveries.Add(delivery);
            _context.SaveChanges();

            return delivery;
        }

        public Delivery GetById(string deliveryId)
        {
            var delivery = _context.Deliveries
                .Include(x => x.Supplier)
                .Include(x => x.Lot)
                .FirstOrDefault(x => x.Id == deliveryId);

            return delivery;
        }

        public Delivery Edit(string deliveryId, string deliveryDate, string supplierName, string lotSerialNumber)
        {
            var supplier = _context.Suppliers.SingleOrDefault(x => x.Name == supplierName);
            var lot = _context.Lots.SingleOrDefault(x => x.SerialNumber == lotSerialNumber);

            var delivery = _context.Deliveries.FirstOrDefault(x => x.Id == deliveryId);
            delivery.DeliveryDate = DateTime.Parse(deliveryDate);
            delivery.Supplier = supplier;
            delivery.Lot = lot;

            _context.Deliveries.Update(delivery);
            _context.SaveChanges();

            return delivery;
        }
    }
}
