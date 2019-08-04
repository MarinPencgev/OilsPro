using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OilsPro.Data;
using OilsPro.Data.Models;
using OilsProDbContext = OilsPro.Web.Areas.Identity.Data.OilsProDbContext;

[assembly: HostingStartup(typeof(OilsPro.Web.Areas.Identity.IdentityHostingStartup))]
namespace OilsPro.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<OilsProDbContext>(options =>
                //    options.UseSqlServer(
                //        context.Configuration.GetConnectionString("DefaultConnection")));

                //services.AddDefaultIdentity<OilsProUser>()
                //    .AddEntityFrameworkStores<OilsProDbContext>();
            });
        }
    }
}