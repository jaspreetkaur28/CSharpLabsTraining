using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek3
{
    class Program
    {

        static int[] array;
        static List<int> list01 = new List<int>(); 
        static Stack<int> stack01 = new Stack<int>();
        static Queue<int> queue01 = new Queue<int>(); 
        static Dictionary<int, int> dictionary = new Dictionary<int, int>();


        static void Main(string[] args)
        {


            //Create a list with 5 items 
            //then iterate over the list :  multiple each item by 2: Add to a Stack!
            //then iterate over the stack: add 10 over each number: add to queue!
            //Iterate over queue: return total
            /*      list01.Add(1);
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

              */



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





            /*  Build an array, queue, list, stack and dictionary.Pass in 3 numbers to the array. 
                  Pass the numbers in turn to the queue, list, stack and dictionary, and whenever
                  you transfer a number also multiply it by 2.
                  

            int array01 = new Array[3];
            array01[0]=1;*/


            int[] numbers = new int[] { 1, 1, 1 };
            foreach (var item in numbers)
            {
                queue01.Enqueue(item * 2);
            } //2
            foreach (var item in queue01)
            {
                list01.Add(item * 2);
            }//4

            foreach (var item in list01)
            {
                stack01.Push(item * 2);

            }//8
            var d = new Dictionary<int, int>();
            for (int i = 0; i < 3; i++)
            {
                d[i] = stack01.Pop() * 2;
            } //16

            var total = 0;
            foreach (var key in d.Keys)
            {
                total += d[key];
            }

            foreach (var item in d)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(total);

        }

        //Phils Code - Separate from the main. 
        public int Collections (int a, int b, int c)
        { /*  Build an array, queue, list, stack and dictionary.Pass in 3 numbers to the array. 
                  Pass the numbers in turn to the queue, list, stack and dictionary, and whenever
                  you transfer a number also multiply it by 2. */
                  
                array  = new int[3] { a, b, c };
                foreach(int item in array )
                {
                  queue01.Enqueue(item * 2);
                } // will be stored as c,b,a with a being at the front of the list.

                while (queue01.Count > 0)
                {
                    list01.Add(queue01.Dequeue()*2);
                } // dequeues it back to normal

                foreach(int item in list01)
                {
                    stack01.Push(item * 2);
                } // stacks them 
                // c
                // b
                // a

                for (int i = 0; i < 3; i++)
                {
                    dictionary[i] = stack01.Pop() * 2;
                // pops it to normal again and times by 2 and gives it a value
                }
                var total = 0;

                foreach(var key in dictionary.Keys)
                {
                    total += dictionary[key]; // sum total of the key in dictionary 
                }
                return total;

        }

    }


}
