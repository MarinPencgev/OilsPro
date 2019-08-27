using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OilsPro.Data;
using OilsPro.Data.Models;
using OilsPro.Services.Test.Common;

namespace OilsPro.Services.Test.Services
{
    public class ProductsServiceTest
    {
        private IProductsService productsService;

        [Test]
        public void Include_And_Remove_Product_To_Order_Work_Correctly()
        {
            string errorMessagePrefix = "ProductsService Include() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();

            Order order = new Order();

            Product product = new Product
            {
                Name = "Product1",
                ProductCode = "01010101",
            };
            Lot lot = new Lot
            {
                SerialNumber = "12/56"
            };

            context.Add(order);
            context.Add(product);
            context.Add(lot);

            context.SaveChanges();

            this.productsService = new ProductsService(context);

            var result = this.productsService.Include(order.Id, product.ProductCode, product.Name, "10", "1800", lot.SerialNumber);

            var expectedResult = context.Orders.First().Products.Count > 0;

            Assert.True(expectedResult, errorMessagePrefix);

            var innerResult = context.Orders.First().Products.First();

            Assert.AreEqual(innerResult, result, errorMessagePrefix);

            var removeProduct = productsService.Remove(result.OrderId + result.ProductId);

            Assert.True(order.Products.Count == 0, errorMessagePrefix);
        }

        [Test]
        public void GetProductsByOrderId_Return_Correct_Result()
        {
            string errorMessagePrefix = "ProductsService GetProductsByOrderId() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.productsService = new ProductsService(context);

            Order order = new Order
            {
                Id = "Order111",
                Products = new List<OrderedProducts>
                {
                    new OrderedProducts
                    {
                        Product = new Product
                        {
                            Name = "Product1",
                            ProductCode = "01010101",
                        }
                    },
                    new OrderedProducts
                    {
                        Product = new Product
                        {
                            Name = "Product2",
                            ProductCode = "02020202",
                        }
                    },
                }
            };

            context.SaveChanges();
            
            var result = productsService.GetProductsByOrderId("Order111").ToList();

            var expected = order.Products.ToList();

            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i], errorMessagePrefix);
            }
        }
    }
}