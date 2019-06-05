using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_90_MVC_CORE.Models
{
    public class ListClass
    {
        public List<String> list { get; set; }
        // or just use 
        //public List<string> list {get; set;} = new List<string>(); instead of the top and bottom code
        public ListClass()
        {
            list = new List<string>();
        }
    }
}
