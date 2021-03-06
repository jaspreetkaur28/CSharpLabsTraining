﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using A_Project_UMSProject.Models;

namespace A_Project_UMSProject.Pages
{
    public class UsersModel : PageModel
    {
        public List<Users> UsersList = new List<Users>(); 
        public void OnGet()
        {
            using (var db = new SpartaDB())
            {
                UsersList = db.Users.ToList();
            }
        }
    }
}