using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponents.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
        public double Cost { get; set; }
        public DateTime LaunchDate { get; set; }
    }
}
