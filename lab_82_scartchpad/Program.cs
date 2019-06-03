using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_82_scartchpad
{
    class Program
    {
        static void Main(string[] args)
        {


            Animal.Age = 2;
              
            Animal.Growing(ref Animal.Age); // passing into method and changes it globally 

            Console.WriteLine(Animal.Age);
 

        }
    } 
    class Animal
    {
        public static int Age;
        public static void Growing(ref int age)
        {
            age++;
        }
 
    }
}
