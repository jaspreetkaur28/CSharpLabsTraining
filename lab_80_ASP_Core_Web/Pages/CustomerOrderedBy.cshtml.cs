using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_80_ASP_Core_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_80_ASP_Core_Web.Pages
{
    public class CustomerOrderedByModel : PageModel
    {
        public List<Customer> customers = new List<Customer>();
 
        public void OnGet()
        {
            using (var db = new Northwind())
            {
                customers =
                (from C in db.Customers
                 where C.City == "London"
                 orderby C.CustomerID ascending
                 select C).ToList();
            }
        }
    }
}