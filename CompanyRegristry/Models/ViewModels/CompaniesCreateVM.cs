using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyRegristry.Models.ViewModels
{
    public class CompaniesCreateVM
    {
        public int Id { get; set; }

        [Display(Name = "Företagsnamn")]
        [Required(ErrorMessage = "Företagsnamn är obligatoriskt")]
        public string Name { get; set; }

        [Display(Name = "Adress")]
        public string Address { get; set; }

        [Display(Name = "Kontaktperson")]
        public string ContactPerson { get; set; }
    }
}
