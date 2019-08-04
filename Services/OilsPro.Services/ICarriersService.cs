using System;
using System.Collections.Generic;
using System.Text;

namespace OilsPro.Services
{
    public interface ICarriersService
    {
        ICollection<string> GetCarrierVehicles(string carrierName);
        ICollection<string> GetCarrierDrivers(string carrierName);
    }
}
