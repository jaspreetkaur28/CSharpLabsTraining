using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using A_ProjectUMS.Models;

namespace A_ProjectUMS.Pages
{
    public class RoleModel : PageModel
    {
        public List<Role> RoleList = new List<Role>();
        public Role NewRole { get; set; }
        public void OnGet()
        {
            using (var db = new SpartaDB())
            {
                RoleList = db.Role.ToList();
            }
        }
        public IActionResult OnPost()
        {
            using (var db = new SpartaDB())
            {
                if (ModelState.IsValid)
                {
                    db.Role.Add(NewRole);
                    db.SaveChanges();
                    return RedirectToPage("/NorthwindCustomers");
                }
            }
            return Page();
        }

    }
}