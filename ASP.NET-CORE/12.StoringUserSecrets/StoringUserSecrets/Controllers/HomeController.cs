using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StoringUserSecrets.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StoringUserSecrets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IConfiguration Configuration { get; }

        public HomeController(ILogger<HomeController> logger, IConfiguration iconfiguration)
        {
            _logger = logger;
            Configuration = iconfiguration;
        }

        public IActionResult Index()
        {
            ViewBag.APIKey = Configuration["MySecretKeys:APIKey"];
            ViewBag.DBPwd = Configuration["MySecretKeys:DBPwd"];
            ViewBag.AdminAccount = Configuration["MySecretKeys:AdminAccount"];

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
