using System;

namespace lab_64_base
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Parent();
            p01.DoThis();
            var c01 = new Child();
            c01.DoThis();

        }
    }
    class Parent
    {
        public virtual void DoThis()
        {
            Console.WriteLine("I'm in the Parent");
        }
    }
    class Child : Parent
    {
        public override void DoThis()
        {
            base.DoThis(); // calls the default method code from the base parent
            Console.WriteLine("I'm in the child");
        }
    }
}
