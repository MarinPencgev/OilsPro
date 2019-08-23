using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OilsPro.Data.Models;

namespace OilsPro.Data
{
    public class OilsProDbContext : IdentityDbContext<OilsProUser, IdentityRole, string>
    {
        public OilsProDbContext(DbContextOptions<OilsProDbContext> options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedProducts> OrderedProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<DeliveryAddress> DeliveryAddresses { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<OrderedProducts>().HasKey(x => new { x.OrderId, x.ProductId, x.LotId});

            builder.Entity<Lot>()
                .HasOne(x => x.Product)
                .WithMany(x => x.Lots)
                .HasForeignKey(x => x.ProductId);

            builder.Entity<Receiver>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.Receiver)
                .HasForeignKey(x => x.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Carrier>()
                .HasMany(x => x.Vehicles)
                .WithOne(x => x.Carrier)
                .HasForeignKey(x => x.CarrierId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Carrier>()
                .HasMany(x => x.Drivers)
                .WithOne(x => x.Carrier)
                .HasForeignKey(x => x.CarrierId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
