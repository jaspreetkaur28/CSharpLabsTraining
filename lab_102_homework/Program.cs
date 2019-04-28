using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_102_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Collections.UseCollections(1, 2, 3, 4, 5));
            Console.WriteLine(Collections.UseCollections(1, 2, 3, 4, 1));
            Console.WriteLine(Collections.UseCollections(1, 1, 1, 1, 1));
        }
    }
    public class Collections
    {
      

        public static int UseCollections(int a,int b, int c, int d, int e)
        {   //Create a list with 5 items 
            //then iterate over the list :  multiple each item by 2: Add to a Stack!
            //then iterate over the stack: add 10 over each number: add to queue!
            //Iterate over queue: return total

            List<int> list01 = new List<int>();
            Stack<int> stack01 = new Stack<int>();
            Queue<int> queue01 = new Queue<int>();
            
            list01.Add(a);
            list01.Add(b);
            list01.Add(c);
            list01.Add(d);
            list01.Add(e);
           
            foreach (int L in list01)
            {
                stack01.Push(L*2);
            }
            foreach ( int S in stack01)
            {
                queue01.Enqueue(S+10);
            }
            
            int sum = queue01.Sum();
            return sum;

            /*
            // LUITZEN's CODE
            for (int i = 0; i < list01.Count; i++)
            {
                stack01.Push(2 * list01[i]);
            }
            while(stack01.Count != 0)
            {
                queue01.Enqueue(10 + stack01.Pop());
            }
            var sum = 0;
            while (queue01.Dequeue !=0)
            {
            sum += queue01.Dequeue();
            }
            return sum;
            */






        }
    }


   
}
