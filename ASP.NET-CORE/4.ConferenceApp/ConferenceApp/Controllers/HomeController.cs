using ConferenceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Web.Services3.Referral;
using System.Diagnostics;
using System.Linq;

namespace ConferenceApp.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public ViewResult RegisterForm()
        {
            return View();
        }


        [HttpPost]
        public ViewResult RegisterForm(WebinarInvites registrationResponse)
        {

            if (ModelState.IsValid)
            {
                Repository.AddResponse(registrationResponse);
                return View("ThankYou", registrationResponse);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillJoin == true) );
        }
    }
}
