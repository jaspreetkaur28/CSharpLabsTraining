using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_38_pass_object_into_method
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Animal("Lion", 12 , 200 );
            var b = new Animal("Tiger", 13 , 150 );
            ProcessAnimals(a);
            ProcessAnimals(a);
            Console.WriteLine($"after processing animal has age {a.Age} and height {a.Weight}");

        }
        //process animals 
        static void ProcessAnimals(Animal animal) {
            var newAnimal = new Animal(animal.Type, animal.Age, animal.Weight);
            animal.Age++;
            animal.Weight += 20;
        }




    }



    class Animal
    {
        public string Type { get; set; } 
        public int Age { get; set; }
        public double Weight { get; set; }
        public Animal(string type, int age, double weight)
        {
            this.Type = type;
            this.Age = age;
            this.Weight = weight;

            //Doesnt need the this. but is more readble is you write this. 
        }

    }



}
