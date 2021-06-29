using Caching.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Caching.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDistributedCache _cache;
        //private readonly IDistributedCache cache;

        public HomeController(ILogger<HomeController> logger, IDistributedCache cache)
        {
            _logger = logger;
            _cache  = cache;
        }

        public async Task<IActionResult> IndexAsync()
        {
            DistributedCacheEntryOptions options = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1)
            };

            if(await _cache.GetStringAsync("MyCache") == null)
            {
                await _cache.SetStringAsync("MyCache", DateTime.Now.ToString(), options);
            }
            //else
            //{
            //    ViewBag.LoadTime = await _cache.GetStringAsync("MyCache");
            //}


            return View();
        }

        public async Task<IActionResult> PrivacyAsync()
        {
            if (await _cache.GetStringAsync("MyCache") != null)
            {
                ViewBag.LoadTime = await _cache.GetStringAsync("MyCache");
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
