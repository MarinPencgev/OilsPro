using System;
using System.Collections.Generic;
using System.Text;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public interface IDeliveriesService
    {
        ICollection<Delivery> GetAll();

        ICollection<Lot> GetAllLots();

        Delivery Create(string deliveryDate, string supplierName, string serialNumber);

        Delivery GetById(string id);

        Delivery Edit(string deliveryId, string deliveryDate, string supplierName, string lotSerialNumber);
    }
}
