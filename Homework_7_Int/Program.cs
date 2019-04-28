using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7_Int
{
    class Program
    {
        /* 
         * Pass an integer into a method the regular way, and make it add 10 and print out (int a)
         * 
         * 
           Pass an integer into a method 'by reference' and make it add 10 and print out, 
           but then check also in the Main method the value still has increased by 10. (int b)
         */

        static void Main(string[] args)
        {
            int b = 100;
            Numbers(10, ref b);
            Console.WriteLine("original b is now " + b); //now 101
        }

        static void Numbers(int a, ref int b)
        {
            a+=10;
            b++;
            Console.WriteLine(a +". b in method is " + b); //101
        }
    }
}
