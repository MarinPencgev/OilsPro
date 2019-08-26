using System;
using Microsoft.EntityFrameworkCore;
using OilsPro.Data;

namespace OilsPro.Services.Test.Common
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
