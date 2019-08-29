using System.Collections;
using System.Collections.Generic;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public interface IReceiverService
    {
        Receiver GetReceiverById(string id);
        ICollection<string> GetAddressesByReceiverName(string receiverId);
        ICollection<DeliveryAddress> GetAddressesByReceiverId(string id);
        Receiver IncludeNewAddress(string receiverId, string town, string street);
        DeliveryAddress EditIncludedAddress(string inputId, string inputTown, string inputStreet);
        Receiver GetReceiverByAddressId(string inputId);
        Receiver Edit(Receiver receiver);
        ICollection<Receiver> GetAllReceivers();
        DeliveryAddress CreateNewAddress(string town, string street, string receiverName);
        DeliveryAddress DeleteAddress(string addressId);
        Receiver Delete(string receiverId);
    }
}
