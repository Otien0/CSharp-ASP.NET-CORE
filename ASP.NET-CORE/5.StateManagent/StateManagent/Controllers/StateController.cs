using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagent.Controllers
{
    public class StateController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Encode"] = 101;
            ViewData["Ename"] = "Moryso";

            ViewBag.Message = "This is comming from ViewBag.Message";

            if(TempData["Country"] == null)
            {
                TempData.Add("Country", "Kenya");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection ifc)
        {
            return View();
        }
    }
}
