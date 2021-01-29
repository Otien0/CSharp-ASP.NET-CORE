using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithControllersDemo.Models;

namespace WorkingWithControllersDemo.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Greetings = "Hello World From MVC Core";
            ViewBag.Name = "Moryso";
            ViewBag.Country = "Kenya";

            Authors obj = new Authors();
            obj.Name = "Mourice Otieno Oduor";
            obj.Course = "BSc in Mathematics And Computer Science";
            obj.College = "Taita Taveta University";
            obj.Country = "Kenya";
            return View(obj); //Passing Model Data to View
        }

        public IActionResult QueryStringDemo(string Message = "Hello World From MVC Core")
        {
            ViewBag.Greetings = Message;
            return View();
        }

        [HttpGet]
        public IActionResult GotoURL(string url = "https://dev-mourice.herokuapp.com/")
        {
            return (Redirect(url));
        }

        [HttpPost]
        public IActionResult GotoURL(IFormCollection ifc)
        {
            string url = ifc["url"];

            if(url == string.Empty)
            {
                return (Redirect("https://dev-mourice.herokuapp.com/"));
            }
            else
            {
                return (Redirect(url));
            }
        }
    }
}
