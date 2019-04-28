using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_Dog02_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog();
            d.Bark();
            var s = new Spaniel();
            s.Bark();
            var p = new Poodle();
            p.Bark();
            var g = new Greyhound();
            g.Bark();
        }
    }
    class Dog
    {
        virtual public void Bark() { Console.WriteLine("WOOF"); } 
    }
    class Spaniel: Dog
    {
        override public void Bark() { Console.WriteLine("wooooof"); }  
    }
    class Poodle : Dog
    {
        override public void Bark() { Console.WriteLine("Woof"); } 
    }

    class Greyhound : Dog
    {
        override public void Bark() { Console.WriteLine("Woof Woof Woof"); } 
    }
}
