using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_36_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //to use this without Parent.DoThis() and public static
            var p = new Parent();
            // can now run the instance method
            p.DoThis(); // onlyonly uses the one instance new parent
            p.DoThis(10); // uses the method with only int parameter
            p.DoThis( "Hi"); // uses the method with only string parameter
            p.DoThis(10,"hi",true); // uses the method with only int string and bool.


            //or a static method 
            Parent.DoThat(); // refers all all of the parent class
        }
    }
    class Parent
    {
        public void DoThis() { Console.WriteLine("Nothing"); }
        public void DoThis(int x) { Console.WriteLine("int"); }
        public void DoThis(string y) { Console.WriteLine("string"); }
        public void DoThis(int x, string y, bool z) { Console.WriteLine("int string and bool ( 3 parameters)"); }
        public static void DoThat() { Console.WriteLine("static method"); } //This one refers to the whole of parent where as the instance method only refers to the one new parent data.
    }
}
