using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10_Nunit


{ //Give a dog class age with 2 types of dogs(inheritance). The values entered via NUNIT. Passing object through method. 
    public class Program
    {
        static int[] array;
        static List<int> List = new List<int>();
        static Stack<int> Stack = new Stack<int>();
        static Queue<int> Queue = new Queue<int>();
        static Dictionary<int, int> Dictionary = new Dictionary<int, int>();
        static void Main(string[] args)
        { }
        public static int number(int a, int b, int c)
        {
            //list queue stack 
            /*  1) Create a class and have both static and instance(regular) methods and show how they work.
              Include also both fields and properties which have get; set; in them.

              2) Create a variance on our array/list/queue/stack/dictionary and add 5 with each operation and get a total
              - see if you can create a test as well to check it works.
              */
             
            array = new int[3] { a, b, c};
            foreach (int item in array)
            {
                List.Add(item+5);
            }  
            foreach (int item in List)
            {
                Queue.Enqueue(item+5);
            }  
            foreach (var item in Queue)
            {
                Stack.Push(item +5);
            }

            for (int i = 0; i < 3; i++)
            {
                Dictionary[i] = Stack.Pop()+ 5; 
            }
            var total = 0;

            foreach (var key in Dictionary.Keys)
            {
                total += Dictionary[key]; 
            }
            return total;

        }
           
    }

   
}
