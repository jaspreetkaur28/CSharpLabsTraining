using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03_loops
{
    class Program
    {
        static void Main(string[] args)
        {

            double speed = 120; // Doesnt actually matter as it gets cancels out in the rounding area
            var miles = speed * 90;
            //90 is 1.5hours in minutes

            var fif = speed * 1.15;
            var sev = speed * 1.75;

            var answer = Math.Round(miles / fif,2);
            var answer2 = Math.Round(miles / sev,2);
            Console.WriteLine("With the speed of " + speed + "mph, you get to your location in 90minutes. ");
            Console.WriteLine(" A 15 % increase of speed will take you  " + answer + " minutes");
            Console.WriteLine(" A 25 % increase of speed will take you  " + answer2 + " minutes");
                







            //  4 types of loops (for, while, do while, for each)
            //for
            Console.WriteLine(" pick a number 1 - 3");
            string userValue = Console.ReadLine();


          if (userValue == "1")
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }
            }

          else  if (userValue == "2") { //for loop
            }
          else if (userValue == "2") { }
          else Console.WriteLine("wrong input");



                
            /*       //for
                      for (int i = 1; i <= 100; i++){}

                      //for - but skip 3
                      for (int i = 1; i <= 100; i+=3) { }


                      // ie 
                      int test = 100;
                      //lets add 3 to the int. 
                      test = test + 3;
                      //OR
                      test += 3;





                   //while (condition is true) {RUN SOME CODE}
                      int counter = 10; 
                      while (counter < 20)
                      {
                          Console.WriteLine(counter);
                          counter++; // keeps the code going after 10 but doesnt print 20.
                      }


                      //do while loop

                      // they do the action first and then ask if the condition is right.
                      Console.WriteLine("\n\bdo..while loop\n\n");
                      int j = 10;
                      do
                      {
                          Console.WriteLine(j);
                          j++;
                      } while (j <= 20);


                      //for each 
                      /*   int numbers = new int[] { 3, 14, 15, 92, 6 };
                      foreach (int number in numbers)
                      {
                          Console.Write($"{number} ");
                      }
                      Console.WriteLine()
                      */ // check lab 08 for better code 


            /*
            String value = "Foreach Loop";
            foreach(char c in value)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();

            */

        }
    }
}
