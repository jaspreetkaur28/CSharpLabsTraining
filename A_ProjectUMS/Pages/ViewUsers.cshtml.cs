using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using A_ProjectUMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A_ProjectUMS.Pages
{
    public class ViewUsersModel : PageModel
    {
        public List<Users> UsersList = new List<Users>();


        public Users UserSelected { get; set; }
        public void OnGet(int id)
        {
            using (var db = new SpartaDB())
            {
                var data = (from user in db.Users
                            where user.UsersID == id
                            select user).SingleOrDefault();
                UserSelected = data; 
            }

        }
         

    }
}