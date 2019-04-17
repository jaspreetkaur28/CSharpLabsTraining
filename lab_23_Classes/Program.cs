using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_23_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create first 'object'  from blueprint 'class'
            var p01 = new Parent();
            p01.Age = 21;
            p01.Height = 1500;
            p01.Name = "George";

            Console.WriteLine($"New person is called {p01.Name}, is {p01.Age} years old and his height is {p01.Height}");
            p01.Grow();

            Console.WriteLine($"New age is {p01.Age}");
            p01.Grow();
            Console.WriteLine($"New age is {p01.Age}");
            p01.Grow();
            Console.WriteLine($"New age is {p01.Age}");
            p01.Grow();
            Console.WriteLine($"New age is {p01.Age}");

        }

        class Parent
        {
            public string Name;
            public int Age;
            public double Height; //double as it may have a remainder

            // Method/ Function
            public void Grow()
            {
                Age++;
            }

        }



    }
}
