using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hw_108_ASP_Core_Web.Models; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hw_108_ASP_Core_Web.Pages
{
    public class MoviesModel : PageModel
    {
       // public List<Movies> MLIST = new List<Movies>();
        public void OnGet()
        {
            using (var db = new HP())
            {
            //    MLIST = db.Movies.ToList();
            }
        }
    }
}