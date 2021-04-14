using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuiltInTagHelpers.Models
{
    public class ProductsData
    {

        private List<Product> _Products = new List<Product>
        {
            new Product {
                ProductID = 1,
                ProductName = "Hp Surface Pro",
                Quantity=100,
                UnitsInStock=50,
                Discontinued = false,
                Cost=58000,
                LaunchDate=new DateTime(2019,10,1)
            },
            new Product {
                ProductID = 2,
                ProductName = "Hp Pavillion-15",
                Quantity=100,
                UnitsInStock=70,
                Discontinued = false,
                Cost=75000,
                LaunchDate=new DateTime(2019,10,5)
            },
               new Product {
                ProductID = 3,
                ProductName = "Hp Pavillion Gaming 15-ryzen",
                Quantity=100,
                UnitsInStock=80,
                Discontinued = false,
                Cost=98000,
                LaunchDate=new DateTime(2019,10,15)
            },
                  new Product {
                ProductID = 4,
                ProductName = "Dell 3538 Celeron",
                Quantity=100,
                UnitsInStock=40,
                Discontinued = false,
                Cost=45000,
                LaunchDate=new DateTime(2019,10,25)
            }

        };

        public IEnumerable<Product> Products => _Products;

    }
}
