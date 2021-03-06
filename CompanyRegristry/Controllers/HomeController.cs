using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CompanyRegristry.Models;

namespace CompanyRegristry.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        //Lägg till funktionalitet för att lista företag och kontaktpersoner
        public IActionResult Index()
        {
            return View();
        }

        //GET: Home/Company
        //Lägg till funktionalitet för att skapa/redigera/tabort
        public IActionResult Company()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        //GET: Home/Contact
        //Lägg till funktionalitet för att skapa/redigera/tabort kontaktperson
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        //GET: Home/Privacy
        //Lägg till funktionalitet för att söka fram företag och kontaktpersoner
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
