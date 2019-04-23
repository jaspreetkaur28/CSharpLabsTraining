using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_32_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. in another method(not recommended as gets messy)
            void DoSomething()
            {
                Console.WriteLine("Hey I am doing something");//MESSY as the code gets nested and if you need more code... more nested and more messy
            } 

            //Call it  
            DoSomething();



            //call static method
            DoSomethingElse();

            var d = new Dog();
            d.Bark();
            //Static field attached to whole class not particular instance 
            // the following cw is for all dogs. 
            Console.WriteLine(Dog.NumLegs);


        }

        //2. In the same class using STATIC KEYWORD which attaches method to this class
        static void DoSomethingElse()
        {
            Console.WriteLine("Hey I'm now doing something else");
            // same as 1. but as a static and outside  of the main method
            //keeps it clean
        }


    }

    class Dog
    {
        public void Bark()
        {
            Console.WriteLine("Dog is now barking loudly");
        }
        public static int NumLegs = 4;

    }
}
