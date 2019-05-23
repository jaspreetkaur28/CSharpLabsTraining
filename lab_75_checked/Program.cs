using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_75_checked
{
    class Program
    {
        static void Main(string[] args)
        {
            short s = 12345;
            int i = 1234567890;
            long l = 1234567890123456789;

            var largeNumber = int.MaxValue; //2 147 483 647 - can take double the values as it takes minus numbers
            var largeUnsignedNumber = uint.MaxValue; //4 ... ... ..5        2^32 = 4 294 967 296

            var smallNumber = int.MinValue;


            Console.WriteLine(largeNumber);
            largeNumber++; // cannot go any higher so loops to the bottom 
            Console.WriteLine(largeNumber);
            largeNumber++;
            Console.WriteLine(largeNumber);
            largeNumber++;
            Console.WriteLine(largeNumber);
            largeNumber++;

            //integers by default: no run time checking for overflow .. they will just keep running. 
            //exception
            // Heavy on the CPU so dont use unless you need it!
            // so need this:
            checked
            {
                var bigNumber = int.MaxValue;
                var biggerBigNumber = bigNumber * 10; /// exception
            }

        }
    }
}
