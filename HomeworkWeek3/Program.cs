using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek3
{
    class Program
    {


        static List<int> list01 = new List<int>();
        static List<char> list02 = new List<char>();
        static Stack<int> stack01 = new Stack<int>();
        static Queue<int> queue01 = new Queue<int>();

        static void Main(string[] args)
        {

             
                //Create a list with 5 items 
                //then iterate over the list :  multiple each item by 2: Add to a Stack!
                //then iterate over the stack: add 10 over each number: add to queue!
                //Iterate over queue: return total
                list01.Add(1);
                list01.Add(1);
                list01.Add(1);
                list01.Add(1);
                list01.Add(1);

                foreach (int L in list01)
                {
                    stack01.Push(L * 2);
                
                }
                foreach (int S in stack01)
                {
                  queue01.Enqueue(S+10);
                }
            int sum = queue01.Sum();

            Console.WriteLine(sum);
            













            /*
            Console.WriteLine("list");
//INT
            list01.Add(1);
            list01.Add(2);
            list01.Add(3);
         
            list01.ForEach(item => Console.WriteLine(item));


 //CHAR 
    
                        list02.Add('a');
                        list02.Add('b');
                        list02.Add('c');
                        foreach (var item in list02)
                        {
                            Console.WriteLine(item);
                        }

  

            Console.WriteLine("Stack");
            for (int i = 0; i < 5; i++)
            {
                stack01.Push(i + 4);
                while (stack01.Count > 0)
                {
                    Console.WriteLine(stack01.Pop());
                }
            }




            Console.WriteLine("Queue");


            for (int i = 0; i < 10; i++)
            {
                queue01.Enqueue(i);
            }
            queue01.Dequeue();
            queue01.Dequeue();
            queue01.Dequeue(); //takes away 3 results in order 
            foreach (int item in queue01)
            {
                Console.WriteLine(item);
            }
         */

        }
        
    }


}
