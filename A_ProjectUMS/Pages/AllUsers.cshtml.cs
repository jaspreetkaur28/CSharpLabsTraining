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

        public int current;
        public void OnGet()
        {
            using (var db = new SpartaDB())
            {
                if (Request.Query.Count == 0)
                {
                    current = 1;
                }
                else { current = Int32.Parse(Request.Query["page"]); }
                current = Math.Max(current, 1);
                current = Math.Min(3, current);

                UsersList = db.Users.ToList();
            }
        }

        public IActionResult OnGetDelete(int id)
        {
            using (var db = new SpartaDB())
            {
                if (id == null)
                {
                    return RedirectToPage("./AllUsers");
                }
                var data = (from o in db.Users
                            where o.UsersID == id
                            select o).SingleOrDefault();

                db.Remove(data);
                db.SaveChanges();
                return RedirectToPage("./AllUsers");
            } 
        }





    }
}