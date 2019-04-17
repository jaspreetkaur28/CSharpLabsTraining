using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_20_truth_tables
{
    class Program
    {
        static void Main(string[] args)
        {
        //AND - are they both high? 
            Console.WriteLine("AND");
            Console.WriteLine(1&1);
            Console.WriteLine(0&0);
            Console.WriteLine(1&0);
            Console.WriteLine(0&1);

         //OR - are either of the high? 
            Console.WriteLine("OR");
            Console.WriteLine(1|1);
            Console.WriteLine(0|0);
            Console.WriteLine(1|0);
            Console.WriteLine(0|1);

            // In real code we use && or || because it's quicker 


            Console.WriteLine(true&&true); // true (checks them both)
            Console.WriteLine(false&&true); //  checks the first one as it's false it doesnt check the second. 

         //XOR - same as the OR but False if either of them is high. - are one and only 1 of them high?
            Console.WriteLine("XOR");
            Console.WriteLine(1 ^ 1); //0
            Console.WriteLine(0 ^ 0); //0
            Console.WriteLine(1 ^ 0); //1
            Console.WriteLine(0 ^ 1); //1

        }
    }
}
