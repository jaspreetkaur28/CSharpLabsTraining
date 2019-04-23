using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_29_collections
{
    class Program
    {
        static List<int> list01 = new List<int>();
        List<string> list02 = new List<string>();
        static Stack<int> stack01 = new Stack<int>();

        static void Main(string[] args)
        {
//LIST 
            list01.Add(10);
            list01.Add(20);
            foreach (var item in list01)
            {
                Console.WriteLine(item);
            }
            //Shorthand for 'Lambda' or 'arrow' syntax for a loop#
            list01.ForEach(item => Console.WriteLine(item));

            DoThis();


//STACK - like the game of tower of Hanoi - you can only move one at a time and with small ontop of big item. 
            stack01.Push(10);//bottom
            stack01.Push(20);//middle
            stack01.Push(30);//top
            Console.WriteLine(stack01.Contains(30)); //true
            Console.WriteLine(stack01.Pop()); //yeild 30 and remove
            foreach (int item in stack01)
            {
                Console.WriteLine(item);
            }
            //peek at top item  which is 20 now
            Console.WriteLine($"Top item is {stack01.Peek()}");



            stack01.Push(40);
            stack01.Push(50);
            //use every item in the stack
                       Console.WriteLine("Using every item from stack");
            while (stack01.Count > 0)
            {
                Console.WriteLine(stack01.Pop());
            }



        }

        static void DoThis()
        {

        }
    }
}
