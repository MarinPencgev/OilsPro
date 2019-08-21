using System.Collections;
using System.Collections.Generic;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public interface IReceiverService
    {
        Receiver GetReceiverById(string id);
        ICollection<string> GetReceiverAddresses(string receiverId);
        ICollection<DeliveryAddress> GetDeliveryAddressesByReceiverId(string id);
        Receiver IncludeNewAddress(string receiverId, string town, string street);
        DeliveryAddress EditIncludedAddress(string inputId, string inputTown, string inputStreet);
        Receiver GetReceiverByAddressId(string inputId);
        void ChangeName(string inputId, string inputName);
        Receiver Edit(Receiver receiver);
    }
}
