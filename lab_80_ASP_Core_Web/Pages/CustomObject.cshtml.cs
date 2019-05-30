using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_80_ASP_Core_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_80_ASP_Core_Web.Pages
{
    public class CustomObjectModel : PageModel
    {
        public List<Customer> customers = new List<Customer>();
        public void OnGet()
        {
            using (var db = new Northwind())
            {
                //customers =
                //(from c in db.Customers
                // select new
                // {

                //     Name = c.ContactName,
                //     City = c.City,
                //     CompanyName //Single values item   
                // }
                // ).To
            }
        }
    }
}