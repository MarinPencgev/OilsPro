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
    public class CarriersVehiclesViewModel : ViewComponent
    {
        private readonly OilsProDbContext _context;

        public CarriersVehiclesViewModel(OilsProDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var vehicles = _context.Vehicles.Where(x => x.CarrierId == id).ToListAsync();

            return View("", await vehicles);
        }
    }
}
