using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 1) Create a class and have both static and instance(regular) methods and show how they work.Include also both fields and properties which have get; set; in them.
namespace Homework_11_Classes_Methods
{

        class Program
        {
            static void Main(string[] args)
            {
                var p = new Parent("Jane", 28);
            }
        }
    
        class Parent
        {
            public string Name { get; set; } 
            public int Age; 

            public Parent(string name, int age) 
            {
                this.Name = name;
                this.Age = age;
            }
        public string Message() { return "hello"; }
        public static string message() { return "hello"; }
            public Parent() { }

        }
        class Child : Parent
        {

        }
    }
