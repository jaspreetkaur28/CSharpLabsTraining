using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using A_ProjectUMS.Models;

namespace A_ProjectUMS.Pages
{
    public class CohortModel : PageModel
    {
        public List<Cohort> CohortList = new List<Cohort>();
        public Cohort NewCohort { get; set; }
        public void OnGet()
        {
            using (var db = new SpartaDB())
            {
                CohortList = db.Cohort.ToList();
            }
        }
        public IActionResult OnPost()
        {
            using (var db = new SpartaDB())
            {
                if (ModelState.IsValid)
                {
                    db.Cohort.Add(NewCohort);
                    db.SaveChanges();
                    return RedirectToPage("/NorthwindCustomers");
                }
            }
            return Page();
        }

    }
}