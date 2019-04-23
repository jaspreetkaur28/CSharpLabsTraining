using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_37_by_reference
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare integer
            int x = 1000;
         //   DoThis(x); // x = 1001 and main x = 1000
            DoThis(ref x); // x = 1001 and main x = 1001 - it follows the varible change throughout
            Console.WriteLine($"x in the main method is {x}");

        }
        static void DoThis( ref int x) { // ref added to know where to follow it to.
            x++;
            Console.WriteLine($"X in the method is {x}");
        }
    }
}
