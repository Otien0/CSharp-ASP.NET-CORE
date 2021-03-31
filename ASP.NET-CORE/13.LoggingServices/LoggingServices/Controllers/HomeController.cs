using LoggingServices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingServices.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogTrace("I am in constructor now.....");
        }

        public IActionResult Index()
        {
            _logger.LogDebug("Just entered Index Action...{0}", DateTime.Now.ToString());

            _logger.LogInformation("Hello World from Logging");

            string s1 = "Hello", s2 = "World";

            _logger.LogInformation("{0} {1}", s1, s2);


            if (s1.Length < 10)
                _logger.LogWarning("Warning : value of s1 is too small...");

            if (s2.Length < 10)
                _logger.LogError("Error : value of s2 is too too small..");

            if (s2.Length < 10)
            {
                _logger.LogCritical("critical : s2 is too small...");
            }
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
