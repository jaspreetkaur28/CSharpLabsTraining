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
        }
    }
    public class Collections
    {
        static List<int> list01 = new List<int>();
        static Stack<int> stack01 = new Stack<int>();
        static Queue<int> queue01 = new Queue<int>();

        public static int UseCollections(int a,int b, int c, int d, int e)
        {
            //Create a list with 5 items 
            //then iterate over the list :  multiple each item by 2: Add to a Stack!
            //then iterate over the stack: add 10 over each number: add to queue!
            //Iterate over queue: return total
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
        }
    }


   
}
