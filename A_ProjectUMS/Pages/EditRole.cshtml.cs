using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using A_ProjectUMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A_ProjectUMS.Pages
{
    public class EditRoleModel : PageModel
    {
        public List<Role> RoleList;

        private SpartaDB db;
        public EditRoleModel(SpartaDB InjectedContext)
        {
            db = InjectedContext;
        }
         [BindProperty]
        public Role RoleSelected { get; set; }
        public void OnGet(int id)
        {
            //using (var db = new SpartaDB())
            //{
                var data = (from r in db.Role
                            where r.RoleID == id
                            select r).SingleOrDefault();
                RoleSelected = data; 
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
                db.Entry(RoleSelected).Property(x => x.RoleName).IsModified = true;  
                db.SaveChanges();
           // }
            return RedirectToPage("ViewUsers");
        }

    }
}