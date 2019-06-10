using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A_ProjectUMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A_ProjectUMS.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
                
        }
    

    public IActionResult OnPost()
    {
        using (var db = new SpartaDB())
        {
            if (ModelState.IsValid)
            {
             //   db.Users.Add(NewRole);
                return RedirectToPage("/Users");
            }
        }
        return Page();
    }
    }
}
