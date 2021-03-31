using CustomFilters.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CustomFilters.Filters;


namespace CustomFilters.Controllers
{
    //[CustomActionFilters]
    //[AsyncCustomActionFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[CustomActionFilters]
        //[AsyncCustomActionFilter]

        // [NewCustomActionFilter]
        [ServiceFilter(typeof(NewCustomActionFilter))]
        public IActionResult Index()
        {
            int a, b, c;
            a = 10;
            b = 20;
            c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;
            return View();
        }

        //[CustomActionFilters]
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
