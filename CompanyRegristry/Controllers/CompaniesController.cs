using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyRegristry.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyRegristry.Controllers
{
    public class CompaniesController : Controller
    {
        //GET: Companies/Test
        public IActionResult Test()
        {
            var company = new Company()
            {
                Name = "Tromb"
            };
            return View(company);
        }
    }
}