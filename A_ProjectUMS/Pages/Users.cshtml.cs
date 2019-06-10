using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using A_ProjectUMS.Models;

namespace A_ProjectUMS.Pages
{
    public class UsersModel : PageModel
    {
        public List<Users> UsersList = new List<Users>();

        public Users NewUsers  { get; set; }

        public void OnGet()
        {
            using (var db = new SpartaDB())
            {
                UsersList = db.Users.ToList();
            }
        }
        public IActionResult OnPost()
        {
            using (var db = new SpartaDB())
            {
                if (ModelState.IsValid)
                {
                    db.Users.Add(NewUsers);
                    db.SaveChanges();
                    return RedirectToPage("/Users");
                }
            }
            return Page();
        }

    }
}