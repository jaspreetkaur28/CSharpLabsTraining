using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_34_optional_and_named_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThis(10, "hi", true);
            DoThis(10, "hi");
            DoThat(10,2); // assigns them respectively ( a= 10 and b =2 and leaves the c and d as what they have already been declared)
            DoThat(d: 7, c: 6, a: 10); //Does it without order. b isnt selected so default value 
        }
        static void DoThis(int x, string y, bool z = false) // z is optional  and has been given a default value
        {

        }
        static void DoThat(int a,int b =5, int c =6, int d =7)  // optional has to be after the required ones.
        {

        }

    }
}
    
