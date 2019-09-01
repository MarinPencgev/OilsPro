using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OilsPro.Services;
using OilsPro.Web.Models.ViewModels;
using System.Linq;
using System.Security.Claims;
using OilsPro.Web.Models.ViewModels.Order;

namespace OilsPro.Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersService _orderService;
        private readonly IProductsService _productsService;
        private readonly IMapper _mapper;
        private readonly ICarriersService _carriersService;

        public OrdersController(IOrdersService orderService,
                                IProductsService productsService,
                                IMapper mapper,
                                ICarriersService carriersService)
        {
            _orderService = orderService;
            _productsService = productsService;
            _mapper = mapper;
            _carriersService = carriersService;
        }

        [Authorize]
        public IActionResult All()
        {
            var completedOrders = _orderService.GetAllCompleted();
            return View(completedOrders);
        }

        [Authorize]
        public IActionResult Create()
        {
            var products = new CreateOrderViewModel();
            
            return View(products);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(CreateOrderViewModel input)
        {
            if (!ModelState.IsValid)
            {
                var products = new CreateOrderViewModel();

                return View(products);
            }
            var carrier = _carriersService.GetAllCarriers()
                .FirstOrDefault(x => x.Name == input.Carrier.Name);
            input.Driver.Carrier = carrier;
            input.Driver.CarrierId = carrier.Id;
            input.Vehicle.Carrier = carrier;
            input.Vehicle.CarrierId = carrier.Id;

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

        [Authorize]
        public IActionResult Edit(string id)
        {
            var order = this._orderService.GetOrderById(id);

            var model = _mapper.Map<CreateOrderViewModel>(order);
            model.DeliveryAddress = order.DeliveryAddress.Town + ", " + order.DeliveryAddress.Street;
            model.OrderedProducts = order.Products;

            return View(model); 
        }

        [Authorize]
        public IActionResult Remove(string id)
        {
            _orderService.Remove(id);
            return this.Redirect("/");
        }

        [Authorize]
        public IActionResult Release(string id)
        {
            var order = _orderService.Release(id);

            var model = _mapper.Map<CreateOrderViewModel>(order);
            model.OrderedProducts = order.Products;
            model.DeliveryAddress = order.DeliveryAddress.Town + ", " + order.DeliveryAddress.Street;

            return this.View(model);
        }
    }
}