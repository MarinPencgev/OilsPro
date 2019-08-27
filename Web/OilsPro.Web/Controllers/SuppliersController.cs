using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OilsPro.Data;
using OilsPro.Services;
using OilsPro.Web.Models.ViewModels;

namespace OilsPro.Web.Controllers
{
    public class SuppliersController: Controller
    {
        private readonly ISuppliersService _suppliersService;
        private readonly IDeliveriesService _deliveriesService;

        public SuppliersController(ISuppliersService suppliersService,IDeliveriesService deliveriesService)
        {
            _suppliersService = suppliersService;
            _deliveriesService = deliveriesService;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(CreateSupplierViewModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View();
            }

            var supplier = _suppliersService.Create(input.Name);

            return this.Redirect("/Deliveries/Create");
        }
        
    }
}
