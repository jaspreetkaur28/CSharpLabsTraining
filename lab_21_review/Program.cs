using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_21_review
{
    class Program
    {
        static void Main(string[] args)
        {
//Truth tables
            //AND 
            Console.WriteLine(1&1); // 1 
            Console.WriteLine(true && false); // false
            //OR
            Console.WriteLine(true||false); // true
           
            //Xor
            Console.WriteLine(false^true);//true 
            Console.WriteLine(true^true);//false

//BOXING
            int i = 7;
            double d = i; // implicit cast from 7(int) to double ==> safe cast! no extra code 

            double dd = 1.99; // chnaging from doube to int means you loose data. the brackets mean you accept and acknowledge the loss of data.
            int j = (int)dd; // explicit : lose 0.99;

            Console.WriteLine((int)'j');

            Console.WriteLine(Math.Round(dd)); //round up  to the decimal point
            Console.WriteLine(Math.Floor(dd)); //round down
            Console.WriteLine(Math.Ceiling(dd)); // always rounds up.

            //Box
            object o = i; // boxing int inside object

            //unbox 
            int jjj = (int)o;

            //null 
            //byte
            // 


//NEW STUFF //String as an array
            string mystring = "some data";
            Console.WriteLine(mystring.Length);
            Console.WriteLine(mystring[0]);
            Console.WriteLine(mystring[1]);
            Console.WriteLine(mystring[mystring.Length -1]); // 9 -1 = 8 ==> starts from 0 to 8 (9 values) to get the last array you minus the total by 1.


            //DateTime
            var d1 = new DateTime();
            var d2 = DateTime.Now;
            var d3 = DateTime.Today;

            var s1 = new System.Diagnostics.Stopwatch();
            s1.Start();
            s1.Stop();




        }
    }
}
