using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OilsPro.Data;
using OilsPro.Data.Models;
using OilsPro.Services;
using OilsPro.Web.Models.ViewModels;

namespace OilsPro.Web.Controllers
{
    public class CarriersController : Controller
    {
        private readonly ICarriersService _carriersService;
        private readonly IMapper _mapper;

        public CarriersController(ICarriersService carriersService, IMapper mapper)
        {
            _carriersService = carriersService;
            _mapper = mapper;
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

        public IActionResult VehiclesDetails(string id)
        {
            var model = _carriersService.GetVehiclesByCarrierId(id);
            return this.View("Components/CarriersVehicles/Default", model);
        }
        public IActionResult DriversDetails(string id)
        {
            var model = _carriersService.GetDriversByCarrierId(id);
            return this.View("Components/CarriersDrivers/Default", model);
        }

        public IActionResult Edit(string id)
        {
            var carrier = _carriersService.GetCarrierById(id);
            var model = _mapper.Map<EditCarrierViewModel>(carrier);
            return this.View("Edit", model);
        }

        [HttpPost]
        public IActionResult Edit(EditCarrierViewModel input)
        {
            var carrier = _mapper.Map<Carrier>(input);
            var editedReceiver = _carriersService.Edit(carrier);
            return this.Redirect("/Nomenclatures/Carriers");
        }
    }
}
