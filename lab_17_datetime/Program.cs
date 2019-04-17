using System;
using System.Diagnostics;

namespace lab_17_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // not helpful - default date set to 1 jan 2001 at midnight
            var d = new DateTime();
            Console.WriteLine(d);


            var f = DateTime.Now;   //now
            Console.WriteLine(f);

            var e = DateTime.Today; //midnight
            Console.WriteLine(e);

            //add calendar day/ week/ month
            e = e.AddDays(1);
            e = e.AddMonths(1);
            e = e.AddHours(1);
            Console.WriteLine(e); // adds 1 to them all


            //elapsed time 
            // use sceonds, millisconds, ticks (10-7 seconds ie 100 nanoseconds!)

            //CRUDE: Subtracting time
            var start = DateTime.Now;
            int total = 0;
            for (int i= 0; i<1000000; i++)
            {
                total+=i;
            }
            var stop = DateTime.Now;
            Console.WriteLine($"Counting took {(stop - start)}");


            // EASY WAY

            var s = new Stopwatch();
            s.Start();
            total = 0;

            for (int i = 0; i<1000000;i++)
            {
                total += i;
            }
            s.Stop();
            Console.WriteLine($"Counting took {s.Elapsed}");
        }
    }
}
