using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTagHelpers.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public IEnumerable<Product> Products { get; set; }


        public List<SelectListItem> Categories { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Fashion" },
            new SelectListItem { Value = "2", Text = "Electronics" },
            new SelectListItem { Value = "3", Text = "Computers"  },
            new SelectListItem { Value = "4", Text = "Sports"  }
        };
    }
}
