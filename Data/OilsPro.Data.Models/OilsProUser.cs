using System;
using Microsoft.AspNetCore.Identity;

namespace OilsPro.Data.Models
{
    public class OilsProUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
