using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_80_ASP_Core_Web.Pages
{
    public class HomeworkModel : PageModel
    {
        public string Something1 { get; set; } = "Default Value";
        public string Something2 { get; set; } = "Default Value";
        public string Something3 { get; set; } = "Default Value";
        public void OnGet()
        {
            Something1 = "hi this is flexbox 1. Words words words words words words words words words";
            Something2 = "hi this is flexbox 2. Words words words words words words words words words";
            Something3 = "hi this is flexbox 3. Words words words words words words words words words";
        }



    }
}