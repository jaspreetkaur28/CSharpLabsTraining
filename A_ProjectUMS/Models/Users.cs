using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A_ProjectUMS.Models
{
    public partial class Users
    {
        public int UsersID { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [StringLength(50,MinimumLength = 8)]
        // [RegularExpression(@" ^ ([\w\.\-] +)@([spartaglobal)(.com) +)$")]

        // [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\com))+)$")]

        public string Email { get; set; } 
        public string Password { get; set; }
        public int CohortID { get; set; }
        public int RoleID { get; set; } 

    } 
}
