﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_80_ASP_Core_Web.Pages
{
    public class UsingAModelModel : PageModel
    {
        public string Property01 { get; set; } = "Default Value";
        //ONGET method is not a constructor : HTML 'Get' request 
        public void OnGet()
        {
            Property01 = "Here is data passed from PageModel into our View";
        }
    }
}   