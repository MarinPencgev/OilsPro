using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OilsPro.Data;

namespace OilsPro.Web.ViewComponents
{
    public class CarriersDriversViewComponent : ViewComponent
    {
        private readonly OilsProDbContext _context;

        public CarriersDriversViewComponent(OilsProDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var drivers = _context.Drivers.Where(x => x.CarrierId == id).ToListAsync();

            return View("", await drivers);
        }
    }
}
