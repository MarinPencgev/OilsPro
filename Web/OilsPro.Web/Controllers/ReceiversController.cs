using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Server.IISIntegration;
using OilsPro.Data.Models;
using OilsPro.Services;
using OilsPro.Web.Models.ViewModels;

namespace OilsPro.Web.Controllers
{
    public class ReceiversController : Controller
    {
        private readonly IReceiverService _receiversService;
        private readonly IMapper _mapper;

        public ReceiversController(IReceiverService receiversService, IMapper mapper)
        {
            _receiversService = receiversService;
            _mapper = mapper;
        }

        [Authorize]
        public IActionResult Edit(string id)
        {
            var receiver = _receiversService.GetReceiverById(id);
            var model = _mapper.Map<EditReceiverViewModel>(receiver);

            return this.View(model);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(EditReceiverViewModel input)
        {
            if (!ModelState.IsValid)
            {
                var modelReceiver = _receiversService.GetReceiverById(input.Id);
                var model = _mapper.Map<EditReceiverViewModel>(modelReceiver);

                return this.View(model);
            }
            var receiver = _mapper.Map<Receiver>(input);
            var editedReceiver = _receiversService.Edit(receiver);

            if (editedReceiver.DeliveryAddresses.Any())
            {
                return this.Redirect("/Nomenclatures/Receivers");
            }
            return this.Redirect($"/Receivers/Edit?id={editedReceiver.Id}");
        }

        [Authorize]
        public IActionResult EditIncludedAddress(string id)
        {
            var receiver = _receiversService.GetReceiverByAddressId(id);

            var address = receiver.DeliveryAddresses.FirstOrDefault(x => x.Id == id);

            return this.View(address);
        }

        [Authorize]
        [HttpPost]
        public IActionResult EditIncludedAddress(EditAddressViewModel input)
        {
            if (!ModelState.IsValid)
            {
                var modelReceiver = _receiversService.GetReceiverByAddressId(input.Id);
                var modelAddress = modelReceiver.DeliveryAddresses.FirstOrDefault(x => x.Id == input.Id);
                return this.View(modelAddress);
            }
            var address = _receiversService.EditIncludedAddress(input.Id, input.Town, input.Street);
            var receiver = _receiversService.GetReceiverByAddressId(input.Id);

            return this.Redirect($"/Receivers/Edit?id={receiver.Id}");
        }

        [Authorize]
        public IActionResult GetReceiverAddresses(string receiverName)
        {
            var addresses = _receiversService.GetAddressesByReceiverName(receiverName);

            return Json(addresses);
        }

        [Authorize]
        public IActionResult IncludeNewAddress(string id)
        {
            ViewBag.ReceiverId = id;

            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult IncludeNewAddress(IncludeAddressViewModel input)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ReceiverId = input.ReceiverId;

                return View();
            }
            _receiversService.IncludeNewAddress(input.ReceiverId, input.Town, input.Street);

            return Redirect($"/Receivers/Edit?id={input.ReceiverId}");
        }

        [Authorize]
        public IActionResult Details(string id)
        {
            var model = _receiversService.GetAddressesByReceiverId(id);

            ViewBag.ReceiverId = id;

            return this.View("Components/ReceiversAddresses/Default", model);
        }

        [Authorize]
        public IActionResult CreateNewAddress()
        {
            List<SelectListItem> list = new List<SelectListItem>
            {
                new SelectListItem("Choose >>>", "Choose >>>")
            };

            var receiverNames = _receiversService.GetAllReceivers()
                .Select(x => x.Name).ToList();

            foreach (var receiver in receiverNames)
            {
                list.Add(new SelectListItem(receiver, receiver));
            }

            ViewBag.Receivers = list;

            return this.View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult CreateNewAddress(CreateDeliveryAddress input)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Receivers = SetReceiversToSelectListItem();

                return this.View();
            }

            var vehicle = _receiversService.CreateNewAddress(input.Town, input.Street, input.ReceiverName);

            return Redirect("/Nomenclatures/Addresses");
        }

        private List<SelectListItem> SetReceiversToSelectListItem()
        {
            List<SelectListItem> list = new List<SelectListItem>
            {
                new SelectListItem("Choose >>>", "Choose >>>")
            };

            var receiverNames = _receiversService.GetAllReceivers()
                .Select(x => x.Name).ToList();

            foreach (var receiver in receiverNames)
            {
                list.Add(new SelectListItem(receiver, receiver));
            }

            return list;
        }

        public IActionResult DeleteAddress(string id)
        {
            var address = _receiversService.DeleteAddress(id);

            var receiverId = address.ReceiverId;

            return this.Redirect($"/Receivers/Edit?id={receiverId}");
        }

        public IActionResult Delete(string id)
        {
            var receiver = _receiversService.Delete(id);

            return this.Redirect("/Nomenclatures/Receivers");
        }
    }
}
