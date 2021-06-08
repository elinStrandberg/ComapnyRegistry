using CompanyRegristry.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyRegristry.Models
{
    public class CompaniesService
    {
        //static int idCounter = 3;
        List<Company> companies = new List<Company>()
        {
            new Company { Id = 1, Name = "Tromb"},
            new Company { Id = 2, Name = "TietoEVRY" },
            new Company { Id = 3, Name = "Future Ltd" }
        };

        public CompaniesIndexVM[] GetAllCompanies()
        {
            return companies
                .Select(o => new CompaniesIndexVM { Id = o.Id, Name = o.Name })
                .ToArray();
        }

        //internal void Add(Company company)
        //{
        //    company.Id = ++idCounter;
        //    companies.Add(company);
        //}
    }
}
