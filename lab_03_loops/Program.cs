using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03_loops
{
    class Program
    {
        static void Main(string[] args)
        {
         //  4 types of loops (for, while, do while, for each)

  /*       //for
            for (int i = 1; i <= 100; i++){}

            //for - but skip 3
            for (int i = 1; i <= 100; i+=3) { }


            // ie 
            int test = 100;
            //lets add 3 to the int. 
            test = test + 3;
            //OR
            test += 3;





         //while (condition is true) {RUN SOME CODE}
            int counter = 10; 
            while (counter < 20)
            {
                Console.WriteLine(counter);
                counter++; // keeps the code going after 10 but doesnt print 20.
            }

            
            //do while loop

            // they do the action first and then ask if the condition is right.
            Console.WriteLine("\n\bdo..while loop\n\n");
            int j = 10;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 20);


            //for each 
            /*   int numbers = new int[] { 3, 14, 15, 92, 6 };
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine()
            */ // check lab 08 for better code 

            String value = "Foreach Loop";
            foreach(char c in value)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();



        }
            }
}
