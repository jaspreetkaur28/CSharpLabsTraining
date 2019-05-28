using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_80_ASP_Core_Web.Pages
{
    public class ListModel : PageModel
    {
        public List<String> items = new List<string>();
        public void OnGet()
        {
            items.Add("first");
            items.Add("second");
            items.Add("third");

        }
    }
}