using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public void Create_works_Properly()
        {
            string errorMessagePrefix = "ProductsService Create() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.productsService = new ProductsService(context);

            var result = productsService.Create("Product1", "01010101", "10/10", 110, 1800);
            var expected = context.Products.First();

            Assert.AreEqual(expected, result, errorMessagePrefix);

        }

        [Test]
        public void Include_And_Remove_Product_To_Order_Works_Correctly()
        {
            string errorMessagePrefix = "ProductsService Include() or Remove() methods does not work properly.";

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

        [Test]
        public void Method_Create_Works_Properly()
        {
            string errorMessagePrefix = "ProductsService Create() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.productsService = new ProductsService(context);

            var product1 = this.productsService.Create("Prod1", "01010101", "20/50", 180, 1800);
            var product2 = this.productsService.Create("Prod2", "02020202", "20/80", 190, 1900);

            Assert.True(context.Products.Count() == 2);
        }

        [Test]
        public void GetProductByCode_Return_Correct_Result()
        {
            string errorMessagePrefix = "ProductsService GetProductByCode() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.productsService = new ProductsService(context);

            var product = new Product
            {
                Name = "Product1",
                ProductCode = "01010101"
            };

            context.Products.Add(product);
            context.SaveChanges();

            var result = productsService.GetProductByCode("01010101");
            var expected = product;

            Assert.AreEqual(expected, result, errorMessagePrefix);
        }

        [Test]
        public void Edit_Return_Correct_Result()
        {
            string errorMessagePrefix = "ProductsService Edit() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.productsService = new ProductsService(context);

            var product = new Product
            {
                Id = "Id1",
                Name = "Product1",
                ProductCode = "01010101",
                Viscosity = "10/10",
                PackageCapacity = 180,
                isDeleted = false,
                
            };
            
            context.Products.Add(product);
            context.SaveChanges();
            
            var editedProduct = new Product
            {
                Id = "Id1",
                Name = "Product2",
                ProductCode = "02020202",
                Viscosity = "20/20",
                PackageCapacity = 220,
                isDeleted = false,
            };

            productsService.Edit(editedProduct);

            var resultProperties = context.Products.First().GetType().GetProperties();
            var expectedProperties = editedProduct.GetType().GetProperties();

            for (int i = 0; i < resultProperties.Length; i++)
            {
                Assert.AreEqual(expectedProperties[i], resultProperties[i]);
            }
        }

        [Test]
        public void Delete_Should_Delete_Product()
        {
            string errorMessagePrefix = "ProductsService Delete() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.productsService = new ProductsService(context);

            var product = new Product
            {
                Id = "Id1",
                Name = "Product1",
                ProductCode = "01010101",
                Viscosity = "10/10",
                PackageCapacity = 180,
                isDeleted = false,
            };

            context.Products.Add(product);
            context.SaveChanges();

            var result = productsService.Delete("Id1");
            
            Assert.True(result.isDeleted);
        }
    }
}