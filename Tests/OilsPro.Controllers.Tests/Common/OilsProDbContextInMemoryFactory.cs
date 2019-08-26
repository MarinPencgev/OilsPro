using System;
using Microsoft.EntityFrameworkCore;
using OilsPro.Data;

namespace OilsPro.Controllers.Tests.Common
{
    public static class OilsProDbContextInMemoryFactory
    {
        public static OilsProDbContext InitializeContext()
        {
            var options = new DbContextOptionsBuilder<OilsProDbContext>()
               .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
               .Options;

            return new OilsProDbContext(options);
        }
    }
}
