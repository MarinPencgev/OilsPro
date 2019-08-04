using System.Collections.Generic;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public interface IProductsService
    {
        OrderedProducts Add(string orderId, string productCode, string productName, string packegesCount, string packegesWeight);
        OrderedProducts Remove(string id);
        ICollection<OrderedProducts> GetProductsByOrderId(string inputId);
        ICollection<Product> GetAll();
        Product Create(string name, string productCode, string viscosity, int packagesCapacity, decimal packagesWeight);
        Product Edit(string id);
    }
}
