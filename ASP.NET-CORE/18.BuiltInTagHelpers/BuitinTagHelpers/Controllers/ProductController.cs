using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuiltInTagHelpers.Models;

namespace BuiltInTagHelpersDemos.Controllers
{
    public class ProductController : Controller
    {
        private ProductsData pData;

      

        public ProductController(ProductsData cData)
        {
            pData = cData;
        }

        public IActionResult Index()
        {
            return View(pData.Products);
        }


        public IActionResult Details(int id)
        {
            return View(pData.Products.FirstOrDefault(a => a.ProductID == id));
        }

        [Route("/Product/ShowAllProducts", Name = "ListOfProducts")]
        public IActionResult ShowAllProducts()
        {
            return View(pData.Products);
        }

    }
}
