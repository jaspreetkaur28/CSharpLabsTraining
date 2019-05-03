
using System;
using System.Diagnostics;

namespace Homework_13_Stopwatch
{
    /* Test 2 
Count from 1 to a given number which increases in powers of 10 ie 10,100,1000,10000 etc
Each time check how long it takes to count from 1 to this given number
Create a test which checks that the Stopwatch() takes less than 5 seconds.
Find the highest value of n for which you can count from 1 up to 10 to the power n in less than 5 seconds.
Repeat for 10 seconds.
Repeat for 20 seconds!
     */
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Counting
        {
            public int CountingNumbers(int power, int maxSeconds) {
                var s = new Stopwatch();
                s.Start();
                for (int i = 0; i < 1000000; i++)
                {
                    i--;
                    i *= 10;
                    Console.WriteLine(-i);

                }
                return -1;
                s.Stop();
                Console.WriteLine($"Counting took {s.Elapsed}");
            }

          

            //i--;
            //i *= 10;
            //Console.WriteLine(-i);
        }


}
}
