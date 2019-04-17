using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_26_methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods can be void, return int or return string

            //Void Method (lab_25_methods)

            //return int
            int ReturnNumber()
            {
                return 12;
            }
            Console.WriteLine(ReturnNumber());


            //return string 
            string ReturnText()
            {
                return "some data";
            }
//3 ways to call and print these

            //1 ReturnText(); doesnt work as it isnt printing it using cw
            Console.WriteLine(ReturnText());

            //2 OR
            Console.WriteLine($"output1 is {ReturnNumber()} and output2 is {ReturnText()}");

            //3 OR
            ReturnNumber();
            ReturnText();
            var output1 = ReturnNumber();
            var output2 = ReturnText();
            Console.WriteLine($"output1 is {ReturnNumber()} and output2 is {ReturnText()}");

            //PASS IN INPUT ALSO INTO A METHOD
            void PrintNumber(int myNumber)
            {
                Console.WriteLine($"My number is {myNumber}");
            }
            PrintNumber(10);
            PrintNumber(100);
            PrintNumber(1000);


            double Cube(int myNumber)
            {
                return Math.Pow(myNumber, 3);
            }
            Console.WriteLine(Cube(2));
            Console.WriteLine(Cube(3));
        }
    }
}
