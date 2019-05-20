using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_65_base_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent("Bob");
            var c = new Child("Tim");
        }
    }
    class Parent
    {
        public string Name;

        public Parent(string Name)
        {
            this.Name = Name;
        }
        public Parent() { }
    }
    class Child : Parent {
 
        public Child(string Name) : base() { }
    }
}
