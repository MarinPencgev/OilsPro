using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [Authorize]
        public IActionResult GetCarrierVehicles(string carrierName)
        {
            var vehicles = _carriersService.GetCarrierVehicles(carrierName);

            return Json(vehicles);
        }

        [Authorize]
        public IActionResult GetCarrierDrivers(string carrierName)
        {
            var drivers = _carriersService.GetCarrierDrivers(carrierName);

            return Json(drivers);
        }

        [Authorize]
        public IActionResult VehiclesDetails(string id)
        {
            var model = _carriersService.GetVehiclesByCarrierId(id);

            ViewBag.CarrierId = id;

            return this.View("Components/CarriersVehicles/Default", model);
        }

        [Authorize]
        public IActionResult DriversDetails(string id)
        {
            var model = _carriersService.GetDriversByCarrierId(id);

            ViewBag.CarrierId = id;

            return this.View("Components/CarriersDrivers/Default", model);
        }

        [Authorize]
        public IActionResult Edit(string id)
        {
            var carrier = _carriersService.GetCarrierById(id);
            var model = _mapper.Map<EditCarrierViewModel>(carrier);

            return this.View(model);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(EditCarrierViewModel input)
        {
            if (!ModelState.IsValid)
            {
                var modelCarrier = _carriersService.GetCarrierById(input.Id);
                var model = _mapper.Map<EditCarrierViewModel>(modelCarrier);

                return this.View(model);
            }
            var carrier = _mapper.Map<Carrier>(input);
            var editedReceiver = _carriersService.Edit(carrier);

            return this.Redirect("/Nomenclatures/Carriers");
        }

        [Authorize]
        public IActionResult EditIncludedVehicle(string id)
        {
            var carrier = _carriersService.GetCarrierByVehicleId(id);
            var vehicle = carrier.Vehicles.FirstOrDefault(x=>x.Id == id);

            return this.View(vehicle);
        }

        [Authorize]
        [HttpPost]
        public IActionResult EditIncludedVehicle(EditVehicleViewModel input)
        {
            if (!ModelState.IsValid)
            {
                var modelCarrier = _carriersService.GetCarrierByVehicleId(input.Id);
                var modelVehicle = modelCarrier.Vehicles.FirstOrDefault(x => x.Id == input.Id);
                return this.View(modelVehicle);
            }

            var vehicle = _carriersService.EditIncludedVehicle(input.Id, input.RegNumber);
            var carrier = _carriersService.GetCarrierByVehicleId(input.Id);

            return this.Redirect($"/Carriers/Edit?id={carrier.Id}");
        }

        [Authorize]
        public IActionResult EditIncludedDriver(string id)
        {
            var carrier = _carriersService.GetCarrierByDriverId(id);
            var driver = carrier.Drivers.FirstOrDefault(x => x.Id == id);

            return this.View(driver);
        }

        [Authorize]
        [HttpPost]
        public IActionResult EditIncludedDriver(EditDriverViewModel input)
        {
            if (!ModelState.IsValid)
            {
                var modelCarrier = _carriersService.GetCarrierByDriverId(input.Id);
                var modelDriver = modelCarrier.Drivers.FirstOrDefault(x => x.Id == input.Id);

                return this.View(modelDriver);
            }

            var driver = _carriersService.EditIncludedDriver(input.Id, input.FullName);
            var carrier = _carriersService.GetCarrierByDriverId(input.Id);

            return this.Redirect($"/Carriers/Edit?id={carrier.Id}");
        }

        [Authorize]
        public IActionResult IncludeNewVehicle(string id)
        {
            ViewBag.CarrierId = id;

            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult IncludeNewVehicle(IncludeVehicleViewModel input)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.CarrierId = input.CarrierId;

                return View();
            }
            _carriersService.IncludeNewVehicle(input.CarrierId, input.RegNumber);

            return Redirect($"/Carriers/Edit?id={input.CarrierId}");
        }

        [Authorize]
        public IActionResult IncludeNewDriver(string id)
        {
            ViewBag.CarrierId = id;

            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult IncludeNewDriver(IncludeDriverViewModel input)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.CarrierId = input.CarrierId;

                return View();
            }
            _carriersService.IncludeNewDriver(input.CarrierId, input.FullName);

            return Redirect($"/Carriers/Edit?id={input.CarrierId}");
        }

        [Authorize]
        public IActionResult DeleteVehicle(string id)
        {
            var carrier = _carriersService.RemoveVehicle(id);

            return this.Redirect($"/Carriers/Edit?id={carrier.Id}");
        }

        [Authorize]
        public IActionResult DeleteDriver(string id)
        {
            var carrier = _carriersService.RemoveDriver(id);

            return this.Redirect($"/Carriers/Edit?id={carrier.Id}");
        }

        [Authorize]
        public IActionResult CreateNewVehicle()
        {
            ViewBag.Carriers = SetCarriersToSelectListItems();

            return this.View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult CreateNewVehicle(CreateVehicleViewModel input)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Carriers = SetCarriersToSelectListItems();

                return this.View();
            }
            var vehicle = _carriersService.CreateNewVehicle(input.RegNumber, input.CarrierName);

            return Redirect("/Nomenclatures/Vehicles");
        }

        [Authorize]
        public IActionResult CreateNewDriver()
        {
            List<SelectListItem> list = new List<SelectListItem>
            {
                new SelectListItem("Choose >>>", "Choose >>>")
            };

            var carrierNames = _carriersService.GetAllCarriers()
                .Select(x => x.Name)
                .ToList();

            foreach (var carrier in carrierNames)
            {
                list.Add(new SelectListItem(carrier, carrier));
            }

            ViewBag.Carriers = list;

            return this.View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult CreateNewDriver(CreateDriverViewModel input)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> list = new List<SelectListItem>
                {
                    new SelectListItem("Choose >>>", "Choose >>>")
                };

                var carrierNames = _carriersService.GetAllCarriers()
                    .Select(x => x.Name)
                    .ToList();

                foreach (var carrier in carrierNames)
                {
                    list.Add(new SelectListItem(carrier, carrier));
                }

                ViewBag.Carriers = list;

                return this.View();
            }
            var vehicle = _carriersService.CreateNewDriver(input.FullName, input.CarrierName);

            return Redirect("/Nomenclatures/Drivers");
        }

        private List<SelectListItem> SetCarriersToSelectListItems()
        {
            List<SelectListItem> list = new List<SelectListItem>
            {
                new SelectListItem("Choose >>>", "Choose >>>")
            };

            var carrierNames = _carriersService.GetAllCarriers()
                .Select(x => x.Name)
                .ToList();

            foreach (var carrier in carrierNames)
            {
                list.Add(new SelectListItem(carrier, carrier));
            }

            return list;
        }
    }
}
