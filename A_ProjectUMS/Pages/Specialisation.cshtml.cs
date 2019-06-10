using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using A_ProjectUMS.Models; 

namespace A_ProjectUMS.Pages
{
    public class SpecialisationModel : PageModel
    {
        public List<Specialisation> SpecialisationList = new List<Specialisation>();
        public Specialisation NewSpecialisation { get; set; }
        public void OnGet()
        {
            using (var db = new SpartaDB())
            {
                SpecialisationList = db.Specialisation.ToList();
            }
        }
        public IActionResult OnPost()
        {
            using (var db = new SpartaDB())
            {
                if (ModelState.IsValid)
                {
                    db.Specialisation.Add(NewSpecialisation);
                    db.SaveChanges();
                    return RedirectToPage("/Specialisation");
                }
            }
            return Page();
        }

    }
}