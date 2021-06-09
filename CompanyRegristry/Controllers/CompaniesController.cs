using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyRegristry.Models;
using CompanyRegristry.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CompanyRegristry.Controllers
{
    public class CompaniesController : Controller
    {
        CompaniesService service = new CompaniesService();

        public CompaniesController(CompaniesService service)
        {
            this.service = service;
        }

        [Route("Home/Company")]
        public IActionResult Company()
        {
            ViewData["Message"] = "Your application description page.";

            var company = new Company() { Name = "Tromb" };

            return View(company);
        }

        [Route("home/company/create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("home/company/create")]
        [HttpPost]
        public IActionResult Create(CompaniesCreateVM company)
        {
            if (!ModelState.IsValid)
                return View(company);

            service.AddCompanies(company);
            return RedirectToAction(nameof(Company));
        }
    }
}