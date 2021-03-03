using DependencyInjection.Models;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ISiteVisitorsCounter _counter, _counter2, _counter3;

        // SiteVisitorsCounter svc = new SiteVisitorsCounter();


        //Constructor Level
        public HomeController(ILogger<HomeController> logger, ISiteVisitorsCounter counter, ISiteVisitorsCounter counter2,
            ISiteVisitorsCounter counter3)
        // public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _counter = counter;
            _counter2 = counter2;
            _counter3 = counter3;
        }

        // public IActionResult Index([FromServices]ISiteVisitorsCounter _counter)
        public IActionResult Index()
        {
            //ViewBag.Counter = svc.GetCounter();
            //ViewBag.Counter = _counter.GetCounter();
            //ViewBag.Counter = _counter.GetCounter();
            //ViewBag.Counter = _counter.GetCounter();

            ViewBag.Counter = _counter.GetCounter();
            ViewBag.Counter = _counter2.GetCounter();
            ViewBag.Counter = _counter3.GetCounter();

            return View();
        }

        public IActionResult Privacy()
        {
            var siteVisitorsCounterService = (ISiteVisitorsCounter)this.HttpContext.RequestServices.GetService(typeof(ISiteVisitorsCounter));

            ViewBag.Counter = siteVisitorsCounterService.GetCounter();

            // ViewBag.Counter = _counter.GetCounter();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
