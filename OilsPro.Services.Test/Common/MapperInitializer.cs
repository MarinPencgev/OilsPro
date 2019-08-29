using System.Reflection;
using OilsPro.Data.Models;

namespace OilsPro.Services.Test.Common
{
    public static class MapperInitializer
    {
        public static void InitializeMapper()
        {
            //AutoMapperConfig.RegisterMappings(
            //    typeof(ProductServiceModel).GetTypeInfo().Assembly,
            //    typeof(Product).GetTypeInfo().Assembly);
        }
    }
}
