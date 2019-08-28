using System.Collections;
using System.Collections.Generic;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public interface IProductsService
    {
        OrderedProducts Include(string orderId, string productCode, string productName, string packegesCount, string packegesWeight, string lot);
        OrderedProducts Remove(string id);
        ICollection<OrderedProducts> GetProductsByOrderId(string inputId);
        ICollection<Product> GetAll();
        Product Create(string name, string productCode, string viscosity, int packagesCapacity, decimal packagesWeight);
        Product GetProductByCode(string productCode);
        void Edit(Product editedProduct);
        Product GetById(string id);
        Product Delete(string productId);
    }
}
