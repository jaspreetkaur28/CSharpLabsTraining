using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab_78_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 
            var s = new Stopwatch();
            s.Start();
            var t = new Task(
                () =>
                {
                    Console.WriteLine("t Starting Task now at time " + s.ElapsedTicks);
                    Thread.Sleep(1000);
                    Console.WriteLine("t Finishing Task now at time " + s.ElapsedTicks);

                }

            );
            t.Start(); // starts the t Task first but the cw line below is shown first because its faster
       //     Thread.Sleep(500); // it now finishes half way through t.
            Console.WriteLine(" main Finished Task now at time " + s.ElapsedTicks);
           // by getting rid of this t never finishes bcause the program is completed it last line of code. 
            ///this  gives t more time to actually finish its job
            ///

            //Decalres it and start with Run() command
            var t02 = Task.Run(

                // this below is called a delegate - a place holder for a method. Not quite a method though.
                () => { Console.WriteLine("t2 Running Task t02 at time" + s.ElapsedTicks); } 

            );



            //Older ways of declaring this 

            //Action Delegate 
            var t03 = Task.Run(
                new Action(Method01));

            Console.ReadLine();


            // Another older way : explicitly using the 'deletegate' keyword 
            //anonymous deletegate with the 'delegate' keyword
            var t04 = Task.Run(
                delegate
                {
                    Console.WriteLine("t4 In Task t04 with anon delegate at " + s.Elapsed);
                });

            //last older way : Task.Factory 

            var t05 = Task.Factory.StartNew(       () =>        { Console.WriteLine("t5 In task 05"); }            );
        }


        static void Method01()
        {
            Console.WriteLine("t3 In Method t03");
        }


    }



    class MSOfficePlugin : IDisposable
    {
        public MSOfficePlugin() { }

        //destructor 
        ~MSOfficePlugin()
        {
            void Dispose();

        }


        public void Dispose() { }
    }

}
