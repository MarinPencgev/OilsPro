using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OilsPro.Data;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public class ProductsService : IProductsService
    {
        private readonly OilsProDbContext _context;

        public ProductsService(OilsProDbContext context)
        {
            _context = context;
        }

        public OrderedProducts Include(string orderId, string productCode, string productName, string packegesCount, string packegesWeight, string lot)
        {
            var product = _context.Products.First(x => x.ProductCode == productCode && x.Name == productName);

            var orderedProduct = new OrderedProducts()
            {
                OrderedPackagesCount = int.Parse(packegesCount),
                OrderedPackagesWeight = decimal.Parse(packegesWeight),
                ProductId = product.Id,
                OrderId = orderId,
                LotId = _context.Products.SelectMany(x => x.Lots).First(x => x.SerialNumber == lot).Id
            };

            _context.OrderedProducts.Add(orderedProduct);
            _context.SaveChanges();

            return orderedProduct;
        }

        public OrderedProducts Remove(string id)
        {
            var orderedProduct = _context.OrderedProducts.First(x => x.OrderId + x.ProductId == id);

            _context.OrderedProducts.Remove(orderedProduct);
            _context.SaveChanges();

            return orderedProduct;
        }

        public ICollection<OrderedProducts> GetProductsByOrderId(string id)
        {
            return _context.OrderedProducts.Where(x => x.OrderId == id).ToList();
        }

        public ICollection<Product> GetAll()
        {
            return _context.Products
                .Include(x => x.Lots)
                .ToList();
        }

        public Product Create(string name, string productCode, string viscosity, int packagesCapacity, decimal packagesWeight)
        {
            var product = new Product()
            {
                Name = name,
                ProductCode = productCode,
                Viscosity = viscosity,
                PackageCapacity = packagesCapacity,
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return product;
        }

        public Product Edit(string id)
        {
            throw new System.NotImplementedException();
        }

        public Product GetByProductCode(string productCode)
        {
            var product = _context.Products
                 .Include(x => x.Lots)
                 .First(x => x.ProductCode == productCode);

            return product;
        }

        public void Edit(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }

        public Product GetById(string id)
        {
            var product = _context.Products
                .Include(x => x.Lots)
                .FirstOrDefault(x => x.Id == id);
            return product;
        }

        public Product Delete(string productId)
        {
            var product = _context.Products.Find(productId);
            product.isDeleted = true;

            _context.SaveChanges();

            return product;
        }
    }
}
