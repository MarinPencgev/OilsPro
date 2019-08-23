using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OilsPro.Web.Models.ViewModels
{
    public class EditDriverViewModel
    {
        public string Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string FullName { get; set; }
    }
}
