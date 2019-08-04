using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OilsPro.Data;

namespace OilsPro.Web.ViewComponents
{
    public class ReceiversAddressesViewComponent: ViewComponent
    {
        private readonly OilsProDbContext _context;

        public ReceiversAddressesViewComponent(OilsProDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var addresses = _context.DeliveryAddresses.Where(x => x.ReceiverId == id).ToListAsync();

            return View(await addresses);
        }
    }
}
