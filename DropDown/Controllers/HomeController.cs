using DropDown.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DropDown.Controllers
{
    public class HomeController : Controller 
    {
        private readonly ILogger<HomeController> _logger;
        public ApplicationDbContext ApplicationDb { get; }

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext
            applicationDb)
        {
            _logger = logger;
            ApplicationDb = applicationDb;
        }
        public IActionResult GetCountry()
        {
            var Country = this.ApplicationDb.Countries.ToList();
            return Json(Country);
        }
        public IActionResult GetState(int id)
        {
            var State = this.ApplicationDb.states.Where(e => e.Country.id == id).ToList();
            return Json(State);
        }
        public IActionResult GetCity(int id)
        {
            var City = this.ApplicationDb.cities.Where(e => e.state.id == id).ToList();
            return Json(City);
        }



        public IActionResult Index()
        {
            return View();
        }

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
