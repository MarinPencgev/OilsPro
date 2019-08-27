﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OilsPro.Data.Models;
using OilsPro.Services;
using OilsPro.Web.Models.ViewModels;

namespace OilsPro.Web.Controllers
{
    public class DeliveriesController: Controller
    {
        private readonly IDeliveriesService _deliveriesService;
        private readonly ISuppliersService _suppliersService;

        public DeliveriesController(IDeliveriesService deliveriesService, ISuppliersService suppliersService)
        {
            _deliveriesService = deliveriesService;
            _suppliersService = suppliersService;
        }
        public IActionResult All()
        {
            var deliveries = _deliveriesService.GetAll();

            return this.View(deliveries);
        }

        public IActionResult Create()
        {
            var model = new Delivery
            {
                DeliveryDate = DateTime.UtcNow
            };

            ViewBag.Suppliers = SetSuppliersToSelectListItems();
            ViewBag.Lots = SetLotsToSelectListItems();

            return this.View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateDeliveryViewModel input)
        {
            if (!ModelState.IsValid)
            {
                var model = new Delivery
                {
                    DeliveryDate = DateTime.UtcNow
                };

                ViewBag.Suppliers = SetSuppliersToSelectListItems();
                ViewBag.Lots = SetLotsToSelectListItems();

                return this.View(model);
            }

            var dlivery = _deliveriesService.Create(input.DeliveryDate.ToString("dd/MM/yyyy"), input.SupplierName, input.LotSerialNumber);

            return this.Redirect($"/Deliveries/All"); 
        }

        public IActionResult CreateNewLot()
        {

            return this.View();
        }

        public IActionResult Edit(string id)
        {
            var delivery = _deliveriesService.GetById(id);

            ViewBag.Suppliers = SetSuppliersToSelectListItems();
            ViewBag.Lots = SetLotsToSelectListItems();

            return this.View(delivery);
        }

        [HttpPost]
        public IActionResult Edit(EditDeliveryViewModel input)
        {
            if (!ModelState.IsValid)
            {
                var modelDelivery = _deliveriesService.GetById(input.Id);

                ViewBag.Suppliers = SetSuppliersToSelectListItems();
                ViewBag.Lots = SetLotsToSelectListItems();

                return this.View(modelDelivery);
            }

            var delivery = _deliveriesService.Edit(input.Id, input.DeliveryDate, input.SupplierName, input.LotSerialNumber);

            return this.Redirect("/Deliveries/All");
        }


        private List<SelectListItem> SetSuppliersToSelectListItems()
        {
            List<SelectListItem> list = new List<SelectListItem>
            {
                new SelectListItem("Choose >>>", "Choose >>>")
            };

            var supplierNames = _suppliersService.GetAll()
                .Select(x => x.Name)
                .ToList();

            foreach (var supplier in supplierNames)
            {
                list.Add(new SelectListItem(supplier, supplier));
            }

            return list;
        }
        private List<SelectListItem> SetLotsToSelectListItems()
        {
            List<SelectListItem> list = new List<SelectListItem>
            {
                new SelectListItem("Choose >>>", "Choose >>>")
            };

            var lotsSerialNumbers = _deliveriesService.GetAllLots()
                .Select(x => x.SerialNumber)
                .ToList();

            foreach (var lot in lotsSerialNumbers)
            {
                list.Add(new SelectListItem(lot, lot));
            }

            return list;
        }
    }
}