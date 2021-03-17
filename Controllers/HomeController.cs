using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy(string first = "Raghava", string last = "Matta",
                                    string email = "rmatta2@uw.edu") //(Would get an error message if I don't add these beforehand) <!-- //tinfo200:[2021-03-10-rmatta2-dykstra1] - For view.-->  
        {
            ViewData["FirstName"] = first;
            ViewData["LastName"] = last;
            ViewData["EmailAddress"] = email; //(Would get an error message if I don't add these beforehand) <!-- //tinfo200:[2021-03-10-rmatta2-dykstra1] - Add sections for code.-->  

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
