using CompanyRegristry.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyRegristry.Models
{
    public class CompaniesService
    {
        
        List<Company> companies = new List<Company>()
        {
            new Company { Id = 1, Name = "Tromb", Address = "Vägen 123", Contactperson = "Kalle" },
            new Company { Id = 2, Name = "TietoEVRY", Address = "Gatan 123", Contactperson = "Lisa" },
            new Company { Id = 3, Name = "Future Ltd", Address = "Street 123", Contactperson = "Kim" }
        };

        public CompaniesIndexVM[] GetAllCompanies()
        {
            return companies
                .Select(o => new CompaniesIndexVM { Id = o.Id, Name = o.Name })
                .ToArray();
        }

        public CompaniesContactsVM GetContactPersons(int id)
        {
            return companies
                .Where(c => c.Id == id)
                .Select(c => new CompaniesContactsVM
                {
                    ContactName = c.Contactperson

                })
                .Single();
        }

        public void AddCompanies(CompaniesCreateVM company)
        {
            companies.Add(new Company
            {
                Id = company.Id,
                Name = company.Name,
                Address = company.Address
            });
        }
    }
}
