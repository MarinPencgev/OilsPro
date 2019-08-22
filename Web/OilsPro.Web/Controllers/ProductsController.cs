using System;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OilsPro.Data.Models;
using OilsPro.Services;
using OilsPro.Web.Models.ViewModels;

namespace OilsPro.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;
        private readonly IOrdersService _ordersService;
        private readonly IMapper _mapper;

        public ProductsController(IProductsService productsService, IOrdersService ordersService, IMapper mapper)
        {
            _productsService = productsService;
            _ordersService = ordersService;
            _mapper = mapper;
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

            //return this.Redirect("/Products/Include");
            return this.Redirect("/Nomenclatures/Products");
        }

        public IActionResult Remove(string id)
        {
            _productsService.Remove(id);

            var currentOrderId = id.Substring(0,36);
            return Redirect($"/Orders/Edit?id={currentOrderId}");
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

        public IActionResult Edit(string id)
        {
            var model = _productsService.GetById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditProductViewModel input)
        {
            var product = _mapper.Map<Product>(input);

            _productsService.Edit(product);

            return this.Redirect("/Nomenclatures/Products");
        }
    }
}