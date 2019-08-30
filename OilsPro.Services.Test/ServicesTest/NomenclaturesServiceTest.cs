using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Moq;
using NUnit.Framework;
using OilsPro.Services.Test.Common;

namespace OilsPro.Services.Test.ServicesTest
{
    public class NomenclaturesServiceTest
    {
        private INomenclaturesService nomenclaturesService;

        [Test]
        public void GetAllLots_works_Properly()
        {
            string errorMessagePrefix = "NomenclaturesServices GetAllLots() method does not work properly.";

            var mapper = new Mock<IMapper>();

            var context = OilsProDbContextInMemoryFactory.InitializeContext();
            this.nomenclaturesService = new NomenclaturesServices(context, mapper.Object);

            var result = nomenclaturesService.All()

        }
    }
}
