using System.Linq;
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

            return this.View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditCarrierViewModel input)
        {
            var carrier = _mapper.Map<Carrier>(input);
            var editedReceiver = _carriersService.Edit(carrier);

            return this.Redirect("/Nomenclatures/Carriers");
        }

        public IActionResult EditIncludedVehicle(string id)
        {
            var carrier = _carriersService.GetCarrierByVehicleId(id);
            var vehicle = carrier.Vehicles.FirstOrDefault(x=>x.Id == id);

            return this.View(vehicle);
        }

        [HttpPost]
        public IActionResult EditIncludedVehicle(EditVehicleViewModel input)
        {
            var vehicle = _carriersService.EditIncludedVehicle(input.Id, input.RegNumber);
            var carrier = _carriersService.GetCarrierByVehicleId(input.Id);

            return this.Redirect($"/Carriers/Edit?id={carrier.Id}");
        }
        public IActionResult CreateNewVehicle(string id)
        {
            var model = new Vehicle()
            {
                CarrierId = id
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateNewVehicle(IncludeVehicleViewModel input)
        {
            _carriersService.IncludeNewVehicle(input.CarrierId, input.RegNumber);

            return Redirect($"/Carriers/Edit?id={input.CarrierId}");
        }

        public IActionResult CreateNewDriver(string id)
        {
            var model = new Driver()
            {
                CarrierId = id
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateNewDriver(IncludeDriverViewModel input)
        {
            _carriersService.IncludeNewDriver(input.CarrierId, input.FullName);

            return Redirect($"/Carriers/Edit?id={input.CarrierId}");
        }

        public IActionResult EditIncludedDriver(string id)
        {
            var carrier = _carriersService.GetCarrierByDriverId(id);
            var driver = carrier.Drivers.FirstOrDefault(x => x.Id == id);

            return this.View(driver);
        }

        [HttpPost]
        public IActionResult EditIncludedDriver(EditDriverViewModel input)
        {
            var driver = _carriersService.EditIncludedDriver(input.Id, input.FullName);
            var carrier = _carriersService.GetCarrierByDriverId(input.Id);

            return this.Redirect($"/Carriers/Edit?id={carrier.Id}");
        }

        public IActionResult DeleteVehicle(string id)
        {
            var carrier = _carriersService.RemoveVehicle(id);

            return this.Redirect($"/Carriers/Edit?id={carrier.Id}");
        }

        public IActionResult DeleteDriver(string id)
        {
            var carrier = _carriersService.RemoveDriver(id);

            return this.Redirect($"/Carriers/Edit?id={carrier.Id}");
        }
    }
}
