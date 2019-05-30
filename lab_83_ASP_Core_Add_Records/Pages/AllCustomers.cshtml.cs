using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_83_ASP_Core_Add_Records.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_83_ASP_Core_Add_Records.Pages
{
    public class AllCustomersModel : PageModel
    {
        public List<Customer> customers; 
        public int current; 
         
        private Northwind db;
        //Constructor to instantiate this db 
        // Instantiate Northwind just once : use for Get() and Post()
        public AllCustomersModel(Northwind InjectedContext)
        {
            db = InjectedContext;
        }


        //Bind proeprty is required for POSTING of data from form 
        [BindProperty]
        public Customer customer { get; set; }

        public void OnGet()
        {
                if (Request.Query.Count == 0)
                {
                    current = 1;
                } 
                else  {  current = Int32.Parse(Request.Query["page"]);  }

                customers = db.Customers.Skip(10 * (current - 1)).Take(10).ToList();  
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
