using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for
            Console.WriteLine("for");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"your number is {i}");
                Console.WriteLine($"your number squared is {i * i}");

            }

            //while (condition is true) {RUN SOME CODE}
            Console.WriteLine("While");
            int counter = 0;
            while (counter < 20)
            {
                Console.WriteLine($"while loop number is {counter}");
                counter++; // keeps the code going after 10 but doesnt print 20.
            }


            //do while loop

            // they do the action first and then ask if the condition is right.
            counter = 0; //reset
            do
            {
                Console.WriteLine($"Do..While: number is {counter}");
                counter++;
            }
            while (counter < 10);

            //ARRAY - fixed size structure which is very fast to access. 
            // talks about why we do i=0
            // DECLARE 
            int[] myIntegerArray = new int[10]; //size has 10 boxes for integers 
            //string [] myStringArray = new string[10]; //size has 10 boxes for string        
            // Access one item 
            // first item has index 0
            myIntegerArray[0] = 100;
            myIntegerArray[1] = 101;
            myIntegerArray[2] = 102;
            //last item : index = size - 1 ie 10-1=[9]
            myIntegerArray[9] = 999;

            //for each - count over every item in the array
            Console.WriteLine("For each");
            foreach (int item in myIntegerArray)
            {
                Console.WriteLine($"item in the array is {item}");

            }

            // Access one item 
            // first item has index 0
            string[] myStringArray = new string[3];
            myStringArray[0] = "Hi";
            myStringArray[1] = "Hello";
            myStringArray[2] = "Bye";

            foreach (string item in myStringArray)
            {
                Console.WriteLine($"item in the array is {item}");

            }

            /*

            String value = "Foreach Loop";
            foreach (char c in value)
            {
                Console.WriteLine($" char is {c}");
            }
            Console.ReadLine();
            */

            Console.WriteLine("for");
            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine($"your number is {i}");
               
            }

            int count = 0;
            while (count <= 20)
            {
                Console.WriteLine($"while loop number is {count}");
                count+=2; // skips every other varible
            }


            var myarray = new int[100]; // Can use int[] instead of var
            for (int x = 0; x < myarray.Length; x++)
            {
                myarray[x]=x; //fills they array
                Console.WriteLine($"item in the array is {x}");
                
            }





        }
    }
}
