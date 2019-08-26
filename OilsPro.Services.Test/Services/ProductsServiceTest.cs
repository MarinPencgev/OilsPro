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

        //Order order = new Order();

        //Product product = new Product
        //{
        //    Name = "Product1",
        //    ProductCode = "01010101",
        //};
        //Lot lot = new Lot
        //{
        //    SerialNumber = "12/56"
        //};

        //private void SeedData(OilsProDbContext context)
        //{
        //    context.Add(lot);
        //    context.Add(product);
        //    context.Add(order);

        //    context.SaveChanges();
        //}

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

            SeedData(context);

            this.productsService = new ProductsService(context);

            var includeProduct1 =
                productsService.Include(order.Id, product.ProductCode, product.Name, "10", "1800", lot.SerialNumber);

            context.Products.Add(new Product
            {
                Name = "Product2",
                ProductCode = "02020202"
            });
            context.SaveChanges();

            var product2 = context.Products.FirstOrDefault(x => x.Name == "Product2");

            var includeProduct2 =
                productsService.Include(order.Id, product2.ProductCode, product2.Name, "20", "3600", lot.SerialNumber);

            var result = this.productsService.GetProductsByOrderId(order.Id).ToList();

            var expectedResult = context.OrderedProducts.Where(x => x.OrderId == order.Id).ToList();

            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(result[i], expectedResult[i], errorMessagePrefix);
            }
        }
    }
}