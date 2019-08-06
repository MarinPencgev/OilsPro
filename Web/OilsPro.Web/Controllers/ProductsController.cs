using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OilsPro.Services;
using OilsPro.Web.Models.ViewModels;

namespace OilsPro.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;
        private readonly IOrdersService _ordersService;

        public ProductsController(IProductsService productsService, IOrdersService ordersService)
        {
            _productsService = productsService;
            _ordersService = ordersService;
        }

        public IActionResult Create(string id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateProductInputView input)
        {
            _productsService.Create(input.Name,
                                    input.ProductCode,
                                    input.Viscosity,
                                    input.PackageCapacity,
                                    input.PackageWeight);

            return this.Redirect("/Products/Include");
        }

        //public IActionResult Include(string id)
        //{
        //    var model = new ProductInputViewModel
        //    {
        //        OrderId = id
        //    };

        //    return this.View("Include",model);
        //}

        //[HttpPost]
        //public IActionResult Include(string id, ProductInputViewModel productInput)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return this.View(productInput); 
        //    }
        //    var currentOrderId = id;
        //    var orderedProduct = _productsService.Include(currentOrderId,
        //                                              productInput.ProductCode,
        //                                              productInput.ProductName,
        //                                              productInput.Count,
        //                                              productInput.Weight);

        //    return Redirect($"/Orders/Edit?id={orderedProduct.OrderId}");
        //}

        public IActionResult Remove(string id)
        {
            _productsService.Remove(id);

            var currentOrderId = id.Substring(0,36);
            return Redirect($"/Orders/Edit?id={currentOrderId}");
        }

        public IActionResult Edit(string id)
        {
            _productsService.Edit(id);

            return Redirect($"/Nomenclatures/Products");
        }

        public IActionResult AllProducts()
        {
            var products = _productsService.GetAll()
                .Select(x=> new
                {
                    Product = x.ProductCode + "-" + x.Name
                })
                .ToList();

            return Json(products);
        }

        public IActionResult GetLotsByProduct(string selectedProduct)
        {
            var productCode = selectedProduct.Substring(0, 8);

            var product = _productsService.GetAll().First(x => x.ProductCode == productCode);

            var productLots = product.Lots.Select(x=>x.SerialNumber).ToList();

            return Json(productLots); 
        }

        public IActionResult Include(string id, string products, string lots, string packagesCount)
        {
            var orderId = id;
            
            var productCode = products.Substring(0, 8);
            var productName = products.Substring(9);

            var product = _productsService.GetByProductCode(productCode);

            var packageCapacity = product.PackageCapacity;

            var density = product.Lots.First(x => x.SerialNumber == lots).Density;

            var packagesWeight = Math.Round(decimal.Parse(packagesCount) * packageCapacity * density, 0).ToString();

            var orderedProduct = _productsService.Include(id, productCode, productName, packagesCount, packagesWeight, lots);

            return this.Redirect($"/Orders/Edit?id={id}");
        }
    }
}