using ConfigurationService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationService.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IConfiguration Configuration { get; }

        private MyApplicationKeysOptions options;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, IOptions<MyApplicationKeysOptions> _options)
        {
            _logger = logger;
            Configuration = configuration;
            options = _options.Value;
        }

        public IActionResult Index()
        {
            ViewBag.LogLevel = Configuration["Logging:LogLevel:Default"];

            ViewBag.AzureSQLServerURL = options.AzureSQLServerURL;
            ViewBag.EmployeePhotoUploadPath = options.EmployeePhotoUploadPath;
            ViewBag.SMTPServer = options.SMTPServer;

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
