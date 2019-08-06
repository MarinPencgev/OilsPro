using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OilsPro.Services;
using OilsPro.Web.Models.ViewModels;

namespace OilsPro.Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersService _orderService;
        private readonly IProductsService _productsService;
        private readonly IMapper _mapper;

        public OrdersController(IOrdersService orderService, IProductsService productsService, IMapper mapper)
        {
            _orderService = orderService;
            _productsService = productsService;
            _mapper = mapper;
        }

        public IActionResult Create()
        {
            var products = new CreateOrderViewModel();
            
            return View(products);
        }

        [HttpPost]
        public IActionResult Create(CreateOrderViewModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input); 
            }

    
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var order = this._orderService.Create(userId,
                                                  input.Purpose.ToString(),
                                                  input.DeliveryAddress,
                                                  input.Receiver.Name,
                                                  input.Carrier.Name,
                                                  input.Driver.FullName,
                                                  input.Vehicle.RegNumber);

            return Redirect($"/Orders/Edit?id={order.Id}");
        }

        public IActionResult Edit(string id)
        {
            var order = this._orderService.GetOrderById(id);

            var model = _mapper.Map<CreateOrderViewModel>(order); 
            model.OrderedProducts = order.Products;

            return View(model); 
        }

        [HttpPost]
        public IActionResult Edit(CreateOrderViewModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }
            input.OrderedProducts = _productsService.GetProductsByOrderId(input.Id);
            _orderService.Edit(input.SequenceNumber,
                               input.Id,
                               input.CreatedOn,
                               input.Purpose,
                               input.Status,
                               input.DeliveryAddress,
                               input.Receiver.Name,
                               input.Carrier.Name,
                               input.Driver.FullName,
                               input.Vehicle.RegNumber);
            return View(input);
        }
        public IActionResult Remove(string id)
        {
            _orderService.Remove(id);
            return this.Redirect("/");
        }

        public IActionResult Release(string id)
        {
            var order = _orderService.Release(id);

            var model = _mapper.Map<CreateOrderViewModel>(order);
            model.OrderedProducts = order.Products;

            return this.View(model);
        }
    }
}