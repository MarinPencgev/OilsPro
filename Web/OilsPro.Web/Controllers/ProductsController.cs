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

            return this.Redirect("/Products/Add");
        }

        public IActionResult Add(string id)
        {
            var model = new ProductInputViewModel
            {
                OrderId = id
            };

            return this.View("Add",model);
        }

        [HttpPost]
        public IActionResult Add(string id, ProductInputViewModel productInput)
        {
            if (!ModelState.IsValid)
            {
                return this.View(productInput); 
            }
            var currentOrderId = id;
            var orderedProduct = _productsService.Add(currentOrderId,
                                                      productInput.ProductCode,
                                                      productInput.ProductName,
                                                      productInput.Count,
                                                      productInput.Weight);

            return Redirect($"/Orders/Edit?id={orderedProduct.OrderId}");
        }

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
    }
}