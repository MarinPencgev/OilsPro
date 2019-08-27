using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OilsPro.Data;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public class SuppliersService : ISuppliersService
    {
        private readonly OilsProDbContext _context;

        public SuppliersService(OilsProDbContext context)
        {
            _context = context;
        }
        public ICollection<Supplier> GetAll()
        {
            var suppliers = _context.Suppliers
                .Where(x=>x.isDeleted == false)
                .Include(x => x.Deliveries)
                .ToList();

            return suppliers;
        }

        public Supplier Create(string name)
        {
            var supplier = new Supplier
            {
                Name = name
            };

            _context.Suppliers.Add(supplier);
            _context.SaveChanges();

            return supplier;
        }
    }
}
