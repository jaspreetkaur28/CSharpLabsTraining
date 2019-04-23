using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_30_queue
{
    class Program
    {
        static Queue<int> queue01 = new Queue<int>();
     //   var queue = new Queue<int>();
        static void Main(string[] args)
        {



            queue01.Enqueue(10);//bottom
            queue01.Enqueue(20);//bottom
            queue01.Enqueue(30);//bottom
            for  (int i = 0; i < 10; i++)
            {
                queue01.Enqueue(i * 10);
            }
            Console.WriteLine( $"This contains the item 50? {queue01.Contains(50)}");

            queue01.Dequeue();
            queue01.Dequeue();
            queue01.Dequeue();
            foreach (int item in queue01)
            {
                Console.WriteLine(item);
            }








            //Doing it as a literal.. didnt work
            //Queue<int> queueOfInts = new Queue<int>(new[] { 4, 3, 2, 1, 0 });
            // Console.WriteLine(queue01.Contains(3)); //true
            // Console.WriteLine(queue01.Dequeue()); 

            /*

            queue01.Enqueue(40);
            queue01.Enqueue(50);
            //use every item in the stack
            Console.WriteLine("Using every item from stack");
            while (queue01.Count > 0)
            {
                Console.WriteLine(queue01.Pop());
            }

            queue.Enqueue(1);
            queue.Dequeue();

            Console.WriteLine($"Top item is {stack01.Peek()}"); */

        }
    }
}
