using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Count to 100 
             if divisible by 3 = fizz 
             if 5 = buzz 
             if 3 and 5 = fizzbuzz 
             others print number
            e.g 1,2 fizz, 4, buzz, 
            */
            for (int i = 1; i <=100; i++)
            {

                if ( i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }

                else Console.WriteLine(i);

                /*  Another way to write the code (almost)
                 
                Console.Write(i);
                   if ( i % 3 == 0)
                  {
                      Console.Write("fizz");
                  }
                  else if (i % 5 == 0)
                  {
                      Console.Write("buzz");
                  }
                 Console.WriteLine();


                 */
            }

        }
    }
}
