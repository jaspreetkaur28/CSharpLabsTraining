using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_83_ASP_Core_Add_Records.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_83_ASP_Core_Add_Records.Pages
{
    public class EditCustomerModel : PageModel
    {
        public List<Customer> customers;
        private Northwind db;
        public EditCustomerModel(Northwind InjectedContext)
        {
            db = InjectedContext;
        }

        //Bind proeprty is required for POSTING of data from form 
        [BindProperty]
        public Customer customer { get; set; }
        public void OnGet(string id)
        {
            if (id != null)
            {
                var data = (from customer in db.Customers
                            where customer.CustomerID == id
                            select customer).SingleOrDefault();
                customer = data;
            }
        }
        
        public IActionResult OnPost()
        { 
            if (!ModelState.IsValid)
            {
                return Page();
            }

            db.Entry(customer).Property(x => x.ContactName).IsModified = true;
            db.Entry(customer).Property(x => x.CompanyName).IsModified = true;
            db.Entry(customer).Property(x => x.City).IsModified = true; 
            db.SaveChanges();
            return RedirectToPage("AllCustomer");
        }

      
    }
}