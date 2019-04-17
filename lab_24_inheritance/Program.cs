using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_24_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Parent();
            p01.Name = "Father";
            var c01 = new Child();
            c01.Name = "Child";

            c01.Age = 3;
            Console.WriteLine("Child's age is ... ");
            Console.WriteLine(c01.GrowReturningAge()); /// replaces c01.Grow();
            Console.WriteLine(c01.GrowReturningAge()); // calls the GrowReturningAge to be printed
            Console.WriteLine(c01.GrowReturningAge());
            var newAge = c01.GrowReturningAge();
            newAge = c01.GrowReturningAge(); // stores the new varible instead of only printing it out via console
        }

        class Parent
        {
            public string Name;
            public int Age;

           /* public void Grow()
            {
                Age++;
            } */// TypeCode is replaced my better code below
            public int GrowReturningAge()
            {
                Age++;
                return Age; // returns the age as it is incremented
            }
        }

        class Child : Parent
        {
            
        }


    }
}
