using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using A_ProjectUMS.Models;

namespace A_ProjectUMS.Pages
{
    public class CreateUserModel : PageModel
    {
       
        
        private SpartaDB db;
        //Constructor to instantiate this db 
        // Instantiate Northwind just once : use for Get() and Post()
        public CreateUserModel(SpartaDB InjectedContext)
        {
            db = InjectedContext;
        }
        [BindProperty]
        public Users NewUsers { get; set; }
        public IActionResult OnPost()
        {

            if (ModelState.IsValid)
            {
                db.Users.Add(NewUsers);
                db.SaveChanges();
                return RedirectToPage("./AllUsers");
            }

            return Page();
        }

    }
}