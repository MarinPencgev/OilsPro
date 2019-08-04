using System.Collections;
using System.Collections.Generic;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public interface IReceiverService
    {
        Receiver GetReceiverById(string id);
        ICollection<string> GetReceiverAddresses(string receiverId);
    }
}
