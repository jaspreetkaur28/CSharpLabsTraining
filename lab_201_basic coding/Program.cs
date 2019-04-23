using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_201_basic_coding
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
               1.Cast from double to integer
               Create a method which takes a double as a parameter and returns the integer which has been cast from this double
               */
            double i = 5.54;
            int ii = (int)i;
            Console.WriteLine(ii);
            /*
               2.. Box then Unbox
                           Create a DateTime object corresponding to 
                           1 Jan 2001 at 1 minute after midnight
                           Box it to an object
                           */

            var e = new DateTime();
           
            object w = e.AddMinutes(1);

          //  int ww = (DateTime)w;
          //  Console.WriteLine(ww); // adds 1 to them all

            //BOXING

            int iii = 100;
            object ooo = iii; //safe

            // unbox

            int jjj = (int)ooo; // unsafe
            Console.WriteLine(jjj);
                                                                              
            /*
               3.Operator Labs
                          1. BODMAS - Write a method which takes a double as an input, squares it, adds 101, divides by 10 then subtracts 4.  Return a double rounded to 3 decimal places.
                          2. Modulus - Write a method which returns the remainder of any integer divided by 8.
                          3. XOR - Create a truth table that returns the XOR of two inputs.
                          */


            Console.WriteLine("MATHS BODMAS");
            double a = 5.555;
            var Squared = Math.Pow(a, 2);
            var Answer =( (Squared + 101) /10)-4;
            Console.WriteLine(Math.Round(Answer,3));

            Console.WriteLine("MODULUS");
            double m = 100;
            Console.WriteLine(m % 8);


            //Math equations 
            //    Math.Pow(var, power number e.g 2 for square)
            // Math.Round(var, number of decimal places e.g 4)
            

            // for ( starting value, range, increment/decrement) {}
            // e.g for (int i = 1; i< 100 ; i++ or i--)


        }
    }
}
