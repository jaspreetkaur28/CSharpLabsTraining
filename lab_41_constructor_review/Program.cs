using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_41_constructor_review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate with default constructor 
          
            var p = new Parent("John", 45);

             
            //default one does not work anymore!
          //  var p = new Parent(); doesnt work as we have instantiated it above
        }
    }
    class Parent
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Parent(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }


}
