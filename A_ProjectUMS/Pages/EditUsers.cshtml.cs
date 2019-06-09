using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using A_ProjectUMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A_ProjectUMS.Pages
{
    public class EditUsersModel : PageModel
    {
        public List<Users> UsersList;

        private SpartaDB db;
        public EditUsersModel(SpartaDB InjectedContext)
        {
            db = InjectedContext;
        }
         [BindProperty]
        public Users UserSelected { get; set; }
        public void OnGet(int id)
        {
            //using (var db = new SpartaDB())
            //{
                var data = (from user in db.Users
                            where user.UsersID == id
                            select user).SingleOrDefault();
                UserSelected = data; 
            //}

        }

        public IActionResult OnPost()
        {
          //  using (var db = new SpartaDB())
          //  {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                db.Entry(UserSelected).Property(x => x.FirstName).IsModified = true; 
                db.Entry(UserSelected).Property(x => x.LastName).IsModified = true;
                db.Entry(UserSelected).Property(x => x.Email).IsModified = true;
                db.Entry(UserSelected).Property(x => x.Password).IsModified = true;
                db.Entry(UserSelected).Property(x => x.CohortID).IsModified = true;
                db.Entry(UserSelected).Property(x => x.RoleID).IsModified = true;
                db.SaveChanges();
           // }
            return RedirectToPage("ViewUsers");
        }

    }
}