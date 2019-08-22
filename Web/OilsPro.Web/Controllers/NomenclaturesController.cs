using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OilsPro.Services;
using OilsPro.Web.Models.ViewModels;

namespace OilsPro.Web.Controllers
{
    public class NomenclaturesController: Controller
    {
        private readonly INomenclaturesService _nomenclaturesService;
        private readonly IReceiverService _receiverService;
        private readonly IMapper _mapper;
        public NomenclaturesController(INomenclaturesService nomenclaturesService, IReceiverService receiverService ,IMapper mapper)
        {
            _nomenclaturesService = nomenclaturesService;
            _receiverService = receiverService;
            _mapper = mapper;
        }
        public IActionResult All()
        {
            var nomenclatures = new Dictionary<string, int>()
            {
                ["Products"] = _nomenclaturesService.GetRecordings("Products"),
                ["Receivers"] = _nomenclaturesService.GetRecordings("Receivers"),
                ["Carriers"] = _nomenclaturesService.GetRecordings("Carriers"),
                ["Vehicles"] = _nomenclaturesService.GetRecordings("Vehicles"),
                ["Drivers"] = _nomenclaturesService.GetRecordings("Drivers"),
                ["Addresses"] = _nomenclaturesService.GetRecordings("Addresses"),
            };
            return this.View(nomenclatures);
        }
        public IActionResult Products()
        {
            var model = _nomenclaturesService.All("Products");
            return this.View(model);
        }
        public IActionResult Receivers()
        {
            var model = _nomenclaturesService.All("Receivers");
            return this.View(model);
        }
        public IActionResult Carriers()
        {
            var model = _nomenclaturesService.All("Carriers");
            return this.View(model);
        }
        public IActionResult Vehicles()
        {
            var model = _nomenclaturesService.All("Vehicles");
            return this.View(model);
        }
        public IActionResult Drivers()
        {
            var model = _nomenclaturesService.All("Drivers");
            return this.View(model);
        }

        public IActionResult Addresses()
        {
            var model = _nomenclaturesService.All("Addresses");
            return this.View(model);
        }
    }
}
