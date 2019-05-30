using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_83_ASP_Core_Add_Records.Models;

namespace lab_83_ASP_Core_Add_Records.Pages
{
    public class NorthwindCustomersModel : PageModel
    {

       public  List<Customer> customers = new List<Customer>();
        public void OnGet()
        {

            using (var db = new Northwind())
            {
                  customers = db.Customers.Skip(10).Take(10).ToList(); //11 -20
              //  customers = db.Customers.ToList(); //11 -20


            }
        }
    }
}