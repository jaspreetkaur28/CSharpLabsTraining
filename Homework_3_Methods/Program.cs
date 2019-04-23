using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_Methods
{
    class Program
    {
       static void Main(string[] args)
        {
            DoThat(1, 2);

       }
        static void DoThat(int a ,int b , int c =3, int d =4, int e = 5)  // optional has to be after the required ones.
        {

        }
    }
    class Parent
    {
        public void DoThat() { Console.WriteLine("Nothing"); }
        public void DoThat(int x) { Console.WriteLine("int parameter only"); }

        public void DoThat(int a, int b, int c, int d, int e) { Console.WriteLine("all 5 parameters"); } //This one refers to the whole of parent where as the instance method only refers to the one new parent data.


    }
}
