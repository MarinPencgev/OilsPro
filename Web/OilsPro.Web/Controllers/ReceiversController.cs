﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

            return this.View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditReceiverViewModel input)
        {
            var receiver = _mapper.Map<Receiver>(input);
            var editedReceiver = _receiversService.Edit(receiver);

            return this.Redirect("/Nomenclatures/Receivers");
        }

        public IActionResult EditIncludedAddress(string id)
        {
            var receiver =  _receiversService.GetReceiverByAddressId(id);
            var address = receiver.DeliveryAddresses.FirstOrDefault(x => x.Id == id);

            return this.View(address);
        }

        [HttpPost]
        public IActionResult EditIncludedAddress(EditAddressViewModel input)
        {
            var address = _receiversService.EditIncludedAddress(input.Id, input.Town, input.Street);
            var receiver = _receiversService.GetReceiverByAddressId(input.Id);

            return this.Redirect($"/Receivers/Edit?id={receiver.Id}");
        }

        public IActionResult GetReceiverAddresses(string receiverName)
        {
            var addresses = _receiversService.GetReceiverAddresses(receiverName);

            return Json(addresses);
        }

        public IActionResult IncludeNewAddress(string id)
        {
            ViewBag.ReceiverId = id;

            return View();
        }

        [HttpPost]
        public IActionResult IncludeNewAddress(IncludeAddressViewModel input)
        {
            _receiversService.IncludeNewAddress(input.ReceiverId, input.Town, input.Street);

            return Redirect($"/Receivers/Edit?id={input.ReceiverId}");
        }

        public IActionResult Details(string id)
        {
            var model = _receiversService.GetDeliveryAddressesByReceiverId(id);

            ViewBag.ReceiverId = id;

            return this.View("Components/ReceiversAddresses/Default", model);
        }

        public IActionResult CreateNewAddress()
        {
            var receivers = _receiversService.GetAllReceivers()
                .Select(x => x.Name)
                .Select(x => new SelectListItem(x, x))
                .ToList();

            ViewBag.Receivers = receivers;

            return this.View();
        }

        [HttpPost]
        public IActionResult CreateNewAddress(CreateDeliveryAddress input)
        {
            var vehicle = _receiversService.CreateNewAddress(input.Town, input.Street, input.ReceiverName);

            return Redirect("/Nomenclatures/Addresses");
        }
    }
}
