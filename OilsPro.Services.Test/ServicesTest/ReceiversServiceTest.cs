using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OilsPro.Data.Models;
using OilsPro.Services.Test.Common;

namespace OilsPro.Services.Test.ServicesTest
{
    public class ReceiversServiceTest
    {
        private IReceiverService receiverService;

        [Test]
        public void CreateNewAddress_works_Properly()
        {
            string errorMessagePrefix = "ReceiverService CreateNewAddress() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.receiverService = new ReceiverService(context);

            var receiver = new Receiver
            {
                Name = "Receiver1",
            };
            context.Receivers.Add(receiver);
            context.SaveChanges();

            var result = receiverService.CreateNewAddress("Town1", "Street1", "Receiver1");

            Assert.True(context.DeliveryAddresses.Contains(result));
        }

        [Test]
        public void Delete_works_Properly()
        {
            string errorMessagePrefix = "ReceiverService Delete() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.receiverService = new ReceiverService(context);

            var receiver = new Receiver
            {
                Name = "Receiver1",
            };
            context.Receivers.Add(receiver);
            context.SaveChanges();

            var result = receiverService.Delete(receiver.Id);

            Assert.True(result.isDeleted);
        }

        [Test]
        public void DeleteAddress_works_Properly()
        {
            string errorMessagePrefix = "ReceiverService DeleteAddress() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.receiverService = new ReceiverService(context);

            var address = new DeliveryAddress()
            {
                Town = "Town1",

            };
            context.DeliveryAddresses.Add(address);
            context.SaveChanges();

            var result = receiverService.DeleteAddress(address.Id);

            Assert.True(result.isDeleted);
        }

        [Test]
        public void EditIncludedAddress_works_Properly()
        {
            string errorMessagePrefix = "ReceiverService EditIncludedAddress() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.receiverService = new ReceiverService(context);
 
            var address = new DeliveryAddress()
            {
                Town = "Town1",
                Street = "Street1",
            };
            context.DeliveryAddresses.Add(address);
            context.SaveChanges();

            var result = receiverService.EditIncludedAddress(address.Id, "Town2", "Street2");

            Assert.True(context.DeliveryAddresses.First().Town == "Town2");
            Assert.True(context.DeliveryAddresses.First().Street == "Street2");
        }

        [Test]
        public void GetAddressesByReceiverId_works_Properly()
        {
            string errorMessagePrefix = "ReceiverService GetAddressesByReceiverId() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.receiverService = new ReceiverService(context);
            var receiver = new Receiver
            {
                Name = "Receiver1",
                DeliveryAddresses = new List<DeliveryAddress>
                {
                    new DeliveryAddress
                    {
                        Town = "Town1",
                        Street = "Street1",
                    },
                    new DeliveryAddress
                    {
                        Town = "Town2",
                        Street = "Street2",
                    },
                }
            };
            
            context.Receivers.Add(receiver);
            context.SaveChanges();

            var result = receiverService.GetAddressesByReceiverId(receiver.Id);

            Assert.True(result.Count == 2);
        }

        [Test]
        public void GetReceiverByAddressId_works_Properly()
        {
            string errorMessagePrefix = "ReceiverService GetReceiverByAddressId() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.receiverService = new ReceiverService(context);
            var receiver = new Receiver
            {
                Name = "Receiver1",
                DeliveryAddresses = new List<DeliveryAddress>
                {
                    new DeliveryAddress
                    {
                        Town = "Town1",
                        Street = "Street1",
                    },
                    new DeliveryAddress
                    {
                        Town = "Town2",
                        Street = "Street2",
                    },
                }
            };

            context.Receivers.Add(receiver);
            context.SaveChanges();
            var addressId = context.DeliveryAddresses.First().Id;

            var result = receiverService.GetReceiverByAddressId(addressId);

            var expected = receiver;

            Assert.AreEqual(expected, result, errorMessagePrefix);
        }

        [Test]
        public void GetReceiverById_works_Properly()
        {
            string errorMessagePrefix = "ReceiverService GetReceiverById() method does not work properly.";

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.receiverService = new ReceiverService(context);
            var receiver = new Receiver
            {
                Name = "Receiver1",
                DeliveryAddresses = new List<DeliveryAddress>
                {
                    new DeliveryAddress
                    {
                        Town = "Town1",
                        Street = "Street1",
                    },
                    new DeliveryAddress
                    {
                        Town = "Town2",
                        Street = "Street2",
                    },
                }
            };

            context.Receivers.Add(receiver);
            context.SaveChanges();

            var result = receiverService.GetReceiverById(receiver.Id);

            var expected = receiver;

            Assert.AreEqual(expected, result, errorMessagePrefix);
        }
    }
}
