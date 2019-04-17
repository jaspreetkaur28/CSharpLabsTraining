using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10_BODMAS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Brackets, Operators, Division, Multiply, Addition, Subtraction
            // 5 squared * 13 cubed - 7/4

            /* my flop way
             * int a = 5;
            int b = 13;
            int c = 7;
            int d = 4;

           void answer ()
            {
             float answer =  (a*a) * (b*b*b)- c / d;
            }

            Console.WriteLine(answer);
            */


            // actual way 
            Console.WriteLine(5*5*13*13*13-(7/4.0));

            var FiveSquared = Math.Pow(5, 2);
            var ThirteenCubed = Math.Pow(13, 3);
            Console.WriteLine(FiveSquared*ThirteenCubed-(7/4.0));

            Console.WriteLine(Math.Sqrt(100));


            Console.WriteLine(100 /8); // = 12 Wrong
            Console.WriteLine(100/8.0); // = 12.5 Right
            Console.WriteLine(100 % 8); //answer = 4 reminder correct  
                                       //100/8 = 12 ... 12*8= 96... 100-96 = 4 Remainder (Modulus)
            


        }
    }
}
