using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_Methods_dog
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = new Dog(4);

            Pet(a);
            Console.WriteLine($"The dog is now {a.Age} years old");

        }
        static void Pet(Dog dog)
        {
            var newAnimal = new Dog(dog.Age);
            dog.Age++;
        }

        class Dog
        {
            public int Age { get; set; }

            public Dog( int age )
            {
                this.Age = age;
            }

        }

    }
}

