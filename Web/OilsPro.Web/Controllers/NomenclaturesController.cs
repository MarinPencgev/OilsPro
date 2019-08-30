using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OilsPro.Services;
using System.Collections.Generic;

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


        [Authorize]
        public IActionResult Products()
        {
            var model = _nomenclaturesService.All("Products");
            return this.View(model);
        }

        [Authorize]
        public IActionResult Receivers()
        {
            var model = _nomenclaturesService.All("Receivers");
            return this.View(model);
        }

        [Authorize]
        public IActionResult Carriers()
        {
            var model = _nomenclaturesService.All("Carriers");
            return this.View(model);
        }

        [Authorize]
        public IActionResult Vehicles()
        {
            var model = _nomenclaturesService.All("Vehicles");
            return this.View(model);
        }

        [Authorize]
        public IActionResult Drivers()
        {
            var model = _nomenclaturesService.All("Drivers");
            return this.View(model);
        }

        [Authorize]
        public IActionResult Addresses()
        {
            var model = _nomenclaturesService.All("Addresses");
            return this.View(model);
        }
    }
}
