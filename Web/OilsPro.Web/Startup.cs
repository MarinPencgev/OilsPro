using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oils;
using OilsPro.Data;
using OilsPro.Data.Models;
using OilsPro.Services;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace OilsPro.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<OilsProDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => 
                    b.MigrationsAssembly("OilsPro.Web")));

            //Password settings
            services.AddIdentity<OilsProUser, IdentityRole>(o =>
            {
                o.Password.RequiredLength = 3;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequireDigit = false;

            })
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<OilsProDbContext>()
                .AddDefaultTokenProviders(); ;

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();

            services.AddSingleton(mapper);

            //Application services
            services.AddTransient<IOrdersService, OrdersService>();
            services.AddTransient<IProductsService, ProductsService>();
            services.AddTransient<IDataSeeder, SeedService>();
            services.AddTransient<INomenclaturesService, NomenclaturesServices>();
            services.AddTransient<IReceiverService, ReceiverService>();
            services.AddTransient<ICarriersService, CarriersService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //Adding Roles
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetRequiredService<OilsProDbContext>())
                {
                    //context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();

                    if (!context.Roles.Any())
                    {
                        var admin = new IdentityRole
                        {
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        };
                        var user = new IdentityRole
                        {
                            Name = "User",
                            NormalizedName = "USER"
                        };
                        context.Roles.Add(admin);
                        context.Roles.Add(user);

                        context.SaveChanges();
                    }
                }
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");

                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
