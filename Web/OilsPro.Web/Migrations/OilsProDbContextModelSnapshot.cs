﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OilsPro.Data;

namespace OilsPro.Web.Migrations
{
    [DbContext(typeof(OilsProDbContext))]
    partial class OilsProDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OilsPro.Data.Models.Carrier", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Carriers");
                });

            modelBuilder.Entity("OilsPro.Data.Models.DeliveryAddress", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ReceiverId")
                        .IsRequired();

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.ToTable("DeliveryAddresses");
                });

            modelBuilder.Entity("OilsPro.Data.Models.Driver", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarrierId")
                        .IsRequired();

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CarrierId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("OilsPro.Data.Models.Lot", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Density");

                    b.Property<int>("PackagesCount");

                    b.Property<decimal>("PackagesWeight");

                    b.Property<string>("ProductId")
                        .IsRequired();

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Lots");
                });

            modelBuilder.Entity("OilsPro.Data.Models.OilsProUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("OilsPro.Data.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarrierId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DeliveryAddressId")
                        .IsRequired();

                    b.Property<string>("DriverId")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("OilsUserId")
                        .IsRequired();

                    b.Property<int>("Purpose");

                    b.Property<string>("ReceiverId");

                    b.Property<DateTime?>("ReleaseDate");

                    b.Property<int>("SequenceNumber")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Status");

                    b.Property<string>("VehicleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CarrierId");

                    b.HasIndex("DeliveryAddressId");

                    b.HasIndex("DriverId");

                    b.HasIndex("OilsUserId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OilsPro.Data.Models.OrderedProducts", b =>
                {
                    b.Property<string>("OrderId");

                    b.Property<string>("ProductId");

                    b.Property<string>("LotId");

                    b.Property<string>("LotId1");

                    b.Property<int>("OrderedPackagesCount");

                    b.Property<decimal>("OrderedPackagesWeight");

                    b.HasKey("OrderId", "ProductId", "LotId");

                    b.HasAlternateKey("LotId", "OrderId", "ProductId");

                    b.HasIndex("LotId1");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderedProducts");
                });

            modelBuilder.Entity("OilsPro.Data.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("PackageCapacity");

                    b.Property<string>("ProductCode")
                        .IsRequired();

                    b.Property<string>("Viscosity")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OilsPro.Data.Models.Receiver", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Receivers");
                });

            modelBuilder.Entity("OilsPro.Data.Models.Vehicle", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarrierId");

                    b.Property<string>("RegNumber")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("CarrierId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OilsPro.Data.Models.OilsProUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OilsPro.Data.Models.OilsProUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OilsPro.Data.Models.OilsProUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OilsPro.Data.Models.OilsProUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OilsPro.Data.Models.DeliveryAddress", b =>
                {
                    b.HasOne("OilsPro.Data.Models.Receiver", "Receiver")
                        .WithMany("DeliveryAddresses")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OilsPro.Data.Models.Driver", b =>
                {
                    b.HasOne("OilsPro.Data.Models.Carrier", "Carrier")
                        .WithMany("Drivers")
                        .HasForeignKey("CarrierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OilsPro.Data.Models.Lot", b =>
                {
                    b.HasOne("OilsPro.Data.Models.Product", "Product")
                        .WithMany("Lots")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OilsPro.Data.Models.Order", b =>
                {
                    b.HasOne("OilsPro.Data.Models.Carrier", "Carrier")
                        .WithMany()
                        .HasForeignKey("CarrierId");

                    b.HasOne("OilsPro.Data.Models.DeliveryAddress", "DeliveryAddress")
                        .WithMany()
                        .HasForeignKey("DeliveryAddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OilsPro.Data.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OilsPro.Data.Models.OilsProUser", "OilsUser")
                        .WithMany()
                        .HasForeignKey("OilsUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OilsPro.Data.Models.Receiver", "Receiver")
                        .WithMany("Orders")
                        .HasForeignKey("ReceiverId");

                    b.HasOne("OilsPro.Data.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OilsPro.Data.Models.OrderedProducts", b =>
                {
                    b.HasOne("OilsPro.Data.Models.Lot", "Lot")
                        .WithMany()
                        .HasForeignKey("LotId1");

                    b.HasOne("OilsPro.Data.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OilsPro.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OilsPro.Data.Models.Vehicle", b =>
                {
                    b.HasOne("OilsPro.Data.Models.Carrier", "Carrier")
                        .WithMany("Vehicles")
                        .HasForeignKey("CarrierId");
                });
#pragma warning restore 612, 618
        }
    }
}
