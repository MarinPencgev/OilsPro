using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Moq;
using NUnit.Framework;
using OilsPro.Services.Test.Common;
using OilsPro.Web.Controllers;

namespace OilsPro.Services.Test.ControllersTest
{
    public class ProductsControllerTest
    {
        [Test]
        public void _works_Properly()
        {
            //IProductsService productsService, IOrdersService ordersService, IMapper mapper
            string errorMessagePrefix = "CarriersService CreateNewDriver() method does not work properly.";
            var p = new Mock<IProductsService>();
            var o = new Mock<IOrdersService>();
            var m = new Mock<IMapper>();
            var productsController = new ProductsController(p.Object, o.Object, m.Object);

        }
    }
}
