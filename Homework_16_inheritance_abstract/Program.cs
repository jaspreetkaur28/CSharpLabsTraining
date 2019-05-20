using System;

namespace Homework_16_inheritance_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent("Jane", 10);
            p.Aging();
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);

            var c = new Child2();
            c.DoThis(); c.DoThat();
            Numbers.NumLegs = 4;
            Numbers.Increasing();
            Console.WriteLine(Numbers.NumLegs);
        }
    }

    /*A Parent-class system with a field, property, and method. 
     * An abstract parent and a real (concrete) child class which can be instantiated. 
     M ke sure there is one abstract method in there and one real method.
     
    A static class system with a static property and static method.*/

    class Parent
    {
        public string Name;
        public int Age { get; set; }

        public Parent(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public int Aging() { Age++; return Age; }
    }


    abstract class Parent2
    {
        abstract public void DoThis();
        public void DoThat() { Console.WriteLine("real"); }

    }
    class Child2 : Parent2
    {
        public override void DoThis()
        {
            Console.WriteLine("HI");
        }
    }

    static class Numbers
    {
        public static int NumLegs { get; set; }

        static public void Increasing() { NumLegs++;}


    }
}
