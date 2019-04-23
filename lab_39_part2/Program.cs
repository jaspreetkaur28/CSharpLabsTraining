using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_39_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Animal();
            p.Sound();
            var d = new Dog();
            d.Sound();
            var c = new Cat();
            c.Sound();
        }
    }
    class Animal
    {
        virtual public void Sound() { Console.WriteLine("Animals make a sound"); } // no static as it doesnt have a instance
        //virtual means it can be overridden by a child
    }
    class Dog: Animal
    {
        override public void Sound() { Console.WriteLine("Dogs bark"); }
        //states it wants to override the default parent value. - optional
    }
    class Cat : Animal
    {
        override public void Sound() { Console.WriteLine("Cats meow"); }
    }
}




/*
 write the parent and child class with the public void and virtual and override
 with the cw 
 
    var letter = new class name ();
    letter.Sound();
*/
