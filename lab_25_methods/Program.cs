using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_25_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Method is a function that we can call. 
              It always has a reutrn type 
              Void is used for sirmple types@ returning nothing 
            */

            //Declaring the function but not running the method (Stating what it does) 
            void DoThis() // void is just stating it 
            {
                Console.WriteLine("i am going something");
            } // this wont run by itself as it isnt called
           
            // Calling the Function
            DoThis(); // executes the function

            for(int i = 1; i<5; i++)
            {
                DoThis();
            } // calls it 5 times as i < 5

        }
    }
}
