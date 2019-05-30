using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_83_ASP_Core_Add_Records.Models;

namespace lab_83_ASP_Core_Add_Records.Pages
{
    public class InjecteCustomersModel : PageModel
    {



   

        public List<Customer> customers;

        private Northwind db;
        //Constructor to instantiate this db 
        // Instantiate Northwind just once : use for Get() and Post()
        public InjecteCustomersModel(Northwind InjectedContext)
        {
            db = InjectedContext; 
        }


        //Bind proeprty is required for POSTING of data from form 
        [BindProperty]
        public Customer customer { get; set; }

        public void OnGet()
        {
            customers = db.Customers.Skip(10).Take(10).ToList();
            // we just instantiated it so dont need using (var db = new Northwind()){} 
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToPage("/NorthwindCustomers");
            }
            return Page();
        }

    }
}