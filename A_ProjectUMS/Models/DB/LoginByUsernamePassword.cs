using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_ProjectUMS.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
    }
}
