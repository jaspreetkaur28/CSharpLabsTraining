using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_Dog01
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog("woof", "Woof Woof", "woooof");
            DogBark(d);
            Console.WriteLine($"First dog: {d.bark}.\nSecond dog: {d.bark2}. \nThird Dog: {d.bark3}");
        }
        static void DogBark(Dog dog)
        {
            var newDog = new Dog(dog.bark, dog.bark2, dog.bark3); 
        } 
    }
    class Dog
    {
        public string bark { get; set; }
        public string bark2 { get; set; }
        public string bark3 { get; set; }
        public Dog(string bark, string bark2, string bark3)
        {
            this.bark = bark;
            this.bark2 = bark2;
            this.bark3 = bark3;
        }
    }
}
