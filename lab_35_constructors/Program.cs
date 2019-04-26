using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_35_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent("fred", 32);

        }
    }
    class Parent
    {
        public string Name { get; set; } //Property
        public int Age; //Field 
                        //two ways. difference between a property and a field is that property has get set?


        //Create a constructor:same name as class
        //this keyword refers to 'instance' ie 'p' above
        public Parent(string name, int age) //can have the same case too
        {
            this.Name = name;
            this.Age = age;
        }
        //defult contructor does not exist
        public Parent(){} 

        //Or
        /*
        Class Parent
        {
            public Parent();
        }*/
    }
    class Child : Parent
    {

    }
}
