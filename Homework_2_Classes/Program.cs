using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            p.Age();
            var c = new Child();
            c.Age();
            c.Gender();
            var g = new Grandchild();
            g.Age();
            g.Gender();

        }
    }

    class Parent
    {
        virtual public void Age()
        {
            Console.WriteLine($"Parents Age is {50}");
            
        }

    }
    class Child:Parent
    {
        override public void Age() { Console.WriteLine($"Childs Age is {25}");  }
        
        virtual public void Gender()
        {
            Console.WriteLine("Child is a Female");
        }
    }
    class Grandchild : Child
    {
        override public void Age() { Console.WriteLine($"Grandchilds Age is {1}"); }
        public override void Gender()
        {
            Console.WriteLine("it's a boy");
        }
    }
}
