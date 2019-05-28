using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab_79_Task_Wait
{
    class Program
    {
        static void Main(string[] args)
        {
            //Real life : array of tasks simulate batch jobs processed
            //During Night 
            var s = new Stopwatch();
            s.Start(); 

            var taskArray = new Task[3];
            taskArray[0] = Task.Run(
                () => {
                    //Thread.Sleep(500);
                    Console.WriteLine("Task 01 finishing at " + s.ElapsedTicks);
                }  );
             taskArray[1] = Task.Run(
                () => {
                  //  Thread.Sleep(1500);
                    Console.WriteLine("Task 02 finishing at " + s.ElapsedTicks);
                }  );
             taskArray[2] = Task.Run(
                () => {
                   // Thread.Sleep(2500);
                    Console.WriteLine("Task 03 finishing at " + s.ElapsedTicks);
                }  );

            var singleTask = Task.Run(() => { Console.WriteLine("single task is finishing at " + s.ElapsedTicks); });
            singleTask.Wait(); // must complete this taask before moving on to the next ones. 

           // Task.WaitAny(taskArray); // wait until at least one task has completed then can start the next code
            Task.WaitAll(taskArray); // wait until all task has completed then can start the next code


            Console.WriteLine("finished" + s.ElapsedTicks); // finishes first because it takes time for the singleTask to run the task.run


            Console.ReadLine();





        }
    }
}
