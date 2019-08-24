using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OilsPro.Data;

namespace OilsPro.Web.ViewComponents
{
    public class CarriersVehiclesViewComponent : ViewComponent
    {
        private readonly OilsProDbContext _context;

        public CarriersVehiclesViewComponent(OilsProDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var vehicles = _context.Vehicles
                .Include(x => x.Carrier)
                .Where(x => x.CarrierId == id && x.isDeleted == false)
                .ToListAsync();

            ViewBag.CarrierId = id;

            return View("", await vehicles);
        }
    }
}
