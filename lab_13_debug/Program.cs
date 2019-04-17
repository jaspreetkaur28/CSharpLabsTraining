using System;
using System.Diagnostics;

namespace lab_13_debug
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 10;
            Console.WriteLine("printing start number is " + start);
            Trace.WriteLine("output " +start);
            int end = 15; 
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();


        }
    }
}
