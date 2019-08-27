using System;
using System.Collections.Generic;
using System.Text;
using OilsPro.Data.Models;

namespace OilsPro.Services
{
    public interface ISuppliersService
    {
        ICollection<Supplier> GetAll();
        Supplier Create(string name);
    }
}
