using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // increment operators - adding one!
            int x = 100;
            // y=x then x++ 
            // y = x=100 then x++ to 101

            int y = x++; // same as int x=100; y=x; x++;
            //always seperate them instead of writing the code like that as it confuses.

            // estimated answer: x = 100 y = 101
            //actual answer: x = 101 y = 100
            Console.WriteLine($"x is {y} and y is {y}");

            int a = 100;
            int b = ++a; // both = 101 
            Console.WriteLine($"a is {a} and b is {b}");


            // GENERAL RULE - just use ++ on it's own separate line!! Best way
            int r= 1000;
            int s = r;
            r++;
            Console.WriteLine($"r is {r} and s is {s}");

            //Not Operater 
            bool isExcellent = true;
        //    bool isRubbish = false;
            Console.WriteLine(isExcellent); // output true
            Console.WriteLine(!isExcellent); // output false
            

        }
    }
}
