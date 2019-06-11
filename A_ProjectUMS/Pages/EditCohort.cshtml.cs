using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using A_ProjectUMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A_ProjectUMS.Pages
{
    
    public class EditCohortModel : PageModel
    {
        public List<Role> RoleList;

        private SpartaDB db;
        public EditCohortModel(SpartaDB InjectedContext)
        {
            db = InjectedContext;
        }
         [BindProperty]
        public Cohort CohortSelected { get; set; }
        public void OnGet(int id)
        {
            //using (var db = new SpartaDB())
            //{
                var data = (from o in db.Cohort
                            where o.CohortID == id
                            select o).SingleOrDefault();
                CohortSelected = data; 
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
                db.Entry(CohortSelected).Property(x => x.CohortName).IsModified = true;  
                db.Entry(CohortSelected).Property(x => x.SpecialisationID).IsModified = true;  
                db.SaveChanges();
           // }
            return RedirectToPage("ViewCohort");
        }

    }
}