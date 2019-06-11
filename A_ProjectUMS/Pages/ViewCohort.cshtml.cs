using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using A_ProjectUMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A_ProjectUMS.Pages
{ 
    public class ViewCohortModel : PageModel
    {
      //  public List<Users> UsersList;

        private SpartaDB db;
        public ViewCohortModel(SpartaDB InjectedContext)
        {
            db = InjectedContext;
        }

        [BindProperty]
        public Cohort CohortSelected { get; set; }
        public void OnGet(int id)
        {   //using (var db = new SpartaDB())
            //{
                var data = (from o in db.Cohort
                            where o.CohortID == id
                            select o).SingleOrDefault();
            CohortSelected = data;
          //  } 
        }



    }
}