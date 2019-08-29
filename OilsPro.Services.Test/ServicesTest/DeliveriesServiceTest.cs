using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OilsPro.Data.Models;
using OilsPro.Services.Test.Common;

namespace OilsPro.Services.Test.ServicesTest
{
    public class DeliveriesServiceTest
    {
        private IDeliveriesService deliveriesService;

        [Test]
        public void Create_works_Properly()
        {
            string errorMessagePrefix = "DeliveriesService Create() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.deliveriesService = new DeliveriesService(context);

            var supplier = new Supplier
            {
                Name = "Supplier1",

            };
            context.Suppliers.Add(supplier);

            var lot = new Lot
            {
                SerialNumber = "56/566"
            };
            context.Lots.Add(lot);

            context.SaveChanges();

            var result = deliveriesService.Create("12-12-1222", supplier.Name, lot.SerialNumber);

            Assert.True(context.Deliveries.Count() == 1);
        }

        [Test]
        public void Edit_works_Properly()
        {
            string errorMessagePrefix = "DeliveriesService Edit() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.deliveriesService = new DeliveriesService(context);

            var supplier = new Supplier
            {
                Name = "Supplier1",

            };
            context.Suppliers.Add(supplier);

            var lot = new Lot
            {
                SerialNumber = "56/566"
            };
            context.Lots.Add(lot);
            var lot2 = new Lot
            {
                SerialNumber = "88/888"
            };
            context.Lots.Add(lot2);

            context.SaveChanges();

            var delivery = deliveriesService.Create("12-12-1222", supplier.Name, lot.SerialNumber);

            var editedDelivery = delivery;
            editedDelivery.Lot = lot2;

            var result = deliveriesService.Edit(editedDelivery.Id, editedDelivery.DeliveryDate.ToString(), editedDelivery.Supplier.Name,
                delivery.Lot.SerialNumber);

            Assert.True(result.Lot.SerialNumber == "88/888");
        }

        [Test]
        public void GetById_works_Properly()
        {
            string errorMessagePrefix = "DeliveriesService GetById() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.deliveriesService = new DeliveriesService(context);

            var supplier = new Supplier
            {
                Name = "Supplier1",

            };
            context.Suppliers.Add(supplier);

            var lot = new Lot
            {
                SerialNumber = "77/77"
            };
            context.Lots.Add(lot);

            var lot2= new Lot
            {
                SerialNumber = "88/88"
            };
            context.Lots.Add(lot2);

            context.SaveChanges();

            var delivery1 = deliveriesService.Create("12-12-1222", supplier.Name, lot.SerialNumber);

            var delivery2 = deliveriesService.Create("10-10-1222", supplier.Name, lot2.SerialNumber);

            var result = deliveriesService.GetById(delivery2.Id);

            Assert.True(result.Lot.SerialNumber == "88/88");
        }


        [Test]
        public void GetAllLots_works_Properly()
        {
            string errorMessagePrefix = "DeliveriesService GetAllLots() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.deliveriesService = new DeliveriesService(context);

            var lot = new Lot
            {
                SerialNumber = "77/77"
            };
            context.Lots.Add(lot);

            var lot2 = new Lot
            {
                SerialNumber = "88/88"
            };
            context.Lots.Add(lot2);

            context.SaveChanges();

            var result = deliveriesService.GetAllLots();

            Assert.True(result.Count == 2);
        }
    }
}
