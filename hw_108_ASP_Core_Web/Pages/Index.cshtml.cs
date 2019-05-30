using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hw_108_ASP_Core_Web.Pages
{
    public class IndexModel : PageModel
    {
        public string Property01 { get; set; } = "Default Value";
        public string Property02 { get; set; } = "Default Value";
        public string Property03 { get; set; } = "Default Value";
        public void OnGet()
        {
            Property01 = "Harry Potter fact file";
            Property02 = "FULL NAME : Harry James Potter";
            Property03 = "BIRTHDAY : 31 July 1980";
        }
    }
}
