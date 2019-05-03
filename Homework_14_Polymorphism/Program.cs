using System;

namespace Homework_14_Polymorphism
{
    class Program
    {/*Check polymorphism works!

Create a Base Parent class 

Create a Derived Child class

Place the same method in both, with the 'virtual' and 'override' keywords.  Test that the parent method returns the string "I am a parent" and the child method returns "I am a child"

         */
        static void Main(string[] args)
        { 
        }
        class BaseParent
        {
            public string outputText()
            {
                return "Hi";
            }
            virtual public void Name() { Console.WriteLine("I am Parent"); }
        }
        class DerivedChild : BaseParent
        {
            override public void Name() { Console.WriteLine("I am child"); }
        }
    }
}
