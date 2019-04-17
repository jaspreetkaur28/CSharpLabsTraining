using System;


namespace lab_01_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Application");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Finished waiting - press any key to exit");

            Console.WriteLine("Printing out arguments array");

            if(args.Length == 0)
            {
                Console.WriteLine("No arguments");
            }
            else
            foreach(string item in args)
            {
                Console.WriteLine("Your item is - " + item);
            }

            Console.ReadLine();
        }
    }
}
