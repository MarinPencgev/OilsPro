using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OilsPro.Data;
using OilsPro.Services;
using OilsPro.Web.Models.ViewModels;

namespace OilsPro.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataSeeder _seeder;
        private readonly IOrdersService _ordersService;
        private readonly OilsProDbContext _context;

        public HomeController(IDataSeeder seeder, IOrdersService ordersService, OilsProDbContext context)
        {
            _seeder = seeder;
            _ordersService = ordersService;
            _context = context;
        }
        public IActionResult Index()
        {
            if (!_context.Receivers.Any())
            {
                _seeder.Seed();
            }

            if (this.User.Identity.IsAuthenticated)
            {
                var uncompletedOrders = _ordersService.GetAllUncomleted();

                var model = uncompletedOrders.Select(x => new UncomletedOrdersViewModel
                {
                    OrderId = x.Id,
                    Sequence = x.SequenceNumber,
                    ReceiverName = x.Receiver.Name,
                    OrderedPackagesCount = x.Products.Sum(p => p.OrderedPackagesCount),
                    OrderedPackagesWeight = x.Products.Sum(p => p.OrderedPackagesWeight),
                    DeliveryAddress = x.DeliveryAddress.Town + ", " + x.DeliveryAddress.Street,
                })
                     .OrderBy(x => x.Sequence)
                     .ToList();
                return this.View("IndexLoggedIn", model);
            }
            else
            {
                return this.View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
