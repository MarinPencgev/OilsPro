using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OilsPro.Data.Models;
using OilsPro.Services;
using OilsPro.Web.Models.ViewModels;

namespace OilsPro.Web.Controllers
{
    public class ReceiversController : Controller
    {
        private readonly IReceiverService _receiversService;
        private readonly IMapper _mapper;

        public ReceiversController(IReceiverService receiversService,IMapper mapper)
        {
            _receiversService = receiversService;
            _mapper = mapper;
        }
        public IActionResult Edit(string id)
        {
            var receiver = _receiversService.GetReceiverById(id);
            var model = _mapper.Map<EditReceiverViewModel>(receiver);
            return this.View("Edit", model);
        }
        [HttpPost]
        public IActionResult Edit(EditReceiverViewModel input)
        {
            var receiver = _mapper.Map<Receiver>(input);
            return this.View();
        }

        public IActionResult GetReceiverAddresses(string receiverName)
        {
            var addresses = _receiversService.GetReceiverAddresses(receiverName);

            return Json(addresses);
        }

        public IActionResult CreateNewAddress()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewAddress(string receiverId)
        {
            //_receiversService.CreateNewAddress(receiverId);

            return Redirect("/Receivers/Edit");
        }


    }
}
