using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using A_ProjectUMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A_ProjectUMS.Pages
{
    public class EditSpecialisationModel : PageModel
    {
        public List<Specialisation> SpecialisationList;

        private SpartaDB db;
        public EditSpecialisationModel(SpartaDB InjectedContext)
        {
            db = InjectedContext;
        }
         [BindProperty]
        public Specialisation SpecialisationSelected { get; set; }
        public void OnGet(int id)
        {
            //using (var db = new SpartaDB())
            //{
                var data = (from o in db.Specialisation
                            where o.SpecialisationID == id
                            select o).SingleOrDefault();
            SpecialisationSelected = data; 
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
                db.Entry(SpecialisationSelected).Property(x => x.SpecialisationName).IsModified = true;  
                db.SaveChanges();
           // }
            return RedirectToPage("/Specialisation");
        }

    }
}