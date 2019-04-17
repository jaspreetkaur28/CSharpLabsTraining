using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_19_casting
{
    class Program
    {
        static void Main(string[] args)
        {

          //safe casting 
            int i = 10;
            double d = i;

         // EXPLICIT (DANGEROUS)  CASTING 
            double dd = 10.79;
            //   int ii = dd;  //error under dd as we will lose the data of .79 
            int ii = (int)dd;  // proper way to wriet it and say yes i know it was delete some data. 
            Console.WriteLine(ii);

         //It's different than rounding! 

            Console.WriteLine(Math.Round(dd)); // output 11 rounds up so depending on the .5 
            Console.WriteLine(Math.Floor(dd)); // output 10  rounds down
            Console.WriteLine(Math.Ceiling(dd)); // output always going up .. ie if it was 10.1 - this would result in 11


         //BOXING

            int iii = 100;
            object ooo = iii; //safe


         // unbox

            int jjj = (int)ooo; // unsafe
            Console.WriteLine(jjj);


        }
    }
}
