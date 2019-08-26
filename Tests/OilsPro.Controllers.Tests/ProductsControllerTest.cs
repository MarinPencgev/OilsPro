using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OilsPro.Controllers.Tests.Common;
using OilsPro.Data;
using OilsPro.Services;
using OilsPro.Web.Controllers;

namespace OilsPro.Controllers.Tests
{
    [TestClass]
    public class ProductsControllerTest
    {
        private IProductsService productsService;
        private IOrdersService ordersService;
        private IMapper mapper;

        [TestMethod]
        public void TestCreateView()
        {
            var controller = new ProductsController(productsService, ordersService, mapper);
            var result = controller.Create() as ViewResult;
            Assert.AreEqual("Create", result.ViewName);
        }
    }
}
