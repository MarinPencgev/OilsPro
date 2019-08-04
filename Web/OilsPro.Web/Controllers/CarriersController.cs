using Microsoft.AspNetCore.Mvc;
using OilsPro.Data;
using OilsPro.Services;

namespace OilsPro.Web.Controllers
{
    public class CarriersController : Controller
    {
        private readonly ICarriersService _carriersService;

        public CarriersController(ICarriersService carriersService)
        {
            _carriersService = carriersService;
        }
        public IActionResult GetCarrierVehicles(string carrierName)
        {
            var vehicles = _carriersService.GetCarrierVehicles(carrierName);

            return Json(vehicles);
        }

        public IActionResult GetCarrierDrivers(string carrierName)
        {
            var drivers = _carriersService.GetCarrierDrivers(carrierName);

            return Json(drivers);
        }
    }
}
