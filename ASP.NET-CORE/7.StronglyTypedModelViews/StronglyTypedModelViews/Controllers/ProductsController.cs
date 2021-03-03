using Microsoft.AspNetCore.Mvc;
using StronglyTypedModelViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StronglyTypedModelViews.Controllers
{
    public class ProductsController : Controller
    {
        static List<Product> _Products = new List<Product>
        {
            new Product {
                ProductID = 1,
                ProductName = "HP NOTEBOOK G590",
                Quantity=100,
                UnitsInStock=50,
                Discontinued = false,
                Cost=3000,
                LaunchDate=new DateTime(2019,10,1)
            },
            new Product {
                ProductID = 2,
                ProductName = "HP PROBOOK 5570",
                Quantity=100,
                UnitsInStock=70,
                Discontinued = false,
                Cost=2500,
                LaunchDate=new DateTime(2019,10,1)
            },
               new Product {
                ProductID = 3,
                ProductName = "MACBOOK PRO 8960",
                Quantity=100,
                UnitsInStock=80,
                Discontinued = false,
                Cost=9000,
                LaunchDate=new DateTime(2019,10,1)
            },
                  new Product {
                ProductID = 4,
                ProductName = "DELL LATITUDE 6480",
                Quantity=100,
                UnitsInStock=40,
                Discontinued = false,
                Cost=1500,
                LaunchDate=new DateTime(2019,10,1)
            }

        };

        public IActionResult Index()
        {
            return View(_Products);
        }

        public IActionResult Detils(int id)
        {
            var prod = _Products.Find(prod => prod.ProductID.Equals(id));
            return View(prod);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var prod = _Products.Find(prod => prod.ProductID.Equals(id));
            return View(prod);
        }

        [HttpPost]

        public IActionResult Edit(Product modifiedProduct)
        {
            var prod = _Products.FirstOrDefault(prod => prod.ProductID.Equals(modifiedProduct.ProductID));

            var indexOf = _Products.IndexOf(prod);

            modifiedProduct.Tax = modifiedProduct.Cost * 10 / 100;

            _Products[indexOf] = modifiedProduct;

            return View("Index", _Products);

            //return View(modifiedProduct);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var prod = _Products.Find(prod => prod.ProductID.Equals(id));
            return View(prod);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteProduct(int id)
        {
            var prod = _Products.Find(prod => prod.ProductID.Equals(id));
            _Products.Remove(prod);
            return View("Index", _Products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product NewProduct)
        {
            if (ModelState.IsValid)
            {
                NewProduct.Tax = NewProduct.Cost * 10 / 100;
                _Products.Add(NewProduct);
                return View("Index", _Products);
            }
            else
            {
                return View();
            }

        }
    };
}
