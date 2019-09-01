using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OilsPro.Services;
using OilsPro.Web.Models.ViewModels;
using OilsPro.Web.Models.ViewModels.Supplier;

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

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
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
