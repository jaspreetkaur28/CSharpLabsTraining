﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_Project_UMSProject.Models
{
    public partial class Users
    {
        public int UsersID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CohortID { get; set; }
        public int RoleID { get; set; } 

    } 
}
