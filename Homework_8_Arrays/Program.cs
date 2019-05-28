using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_Arrays
{ //Create an array of 5 strings, array01.
  //Copy it to a second array, array02. Change one value and check the value has changed in both arrays.
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i+=4)
            {
                Console.WriteLine(i);
            }


            for (int i = 0; i < 100; i++)
            {
                if(i%4==0)
                    Console.WriteLine(i);
            }




            string[] array01 = new string[5] { "hii", "there", "how", "are", "you" };

            foreach (string item in array01)
            {
                Console.WriteLine(item);
            }
            var array02 = array01;
            array02[1] = "No";
            foreach (string item in array02)
            {
                Console.WriteLine(item);
            }
            foreach (string item in array01)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
