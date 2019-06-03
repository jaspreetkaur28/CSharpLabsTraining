using System;
using System.Linq;

namespace hw_109_linq_aggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class LINQAggregate
    {
        public static int LINQAggregateSum(int[] array)
        {
            // Use linq aggregate to sum all members of array 
            //e.g array [1,2,3] ==> 6 
             
            var sum = array.Aggregate((a, b) => a + b);
            return sum;
        }

        public static string[] LINQUnion(string[] array1, string[] array2)
        {

            string[] arr = array1.Union(array2).ToArray(); 
            return   arr;
            //use linq union to  join 2 arrays and elimatinate duplicates
        }


        public static string[] LINQIntersect(string[] array1, string[] array2)
        {
            var arr = array1.Intersect(array2).ToArray();
            return arr;
            //use linq union to  join 2 arrays and elimatinate duplicates
        }

        //repeat for linq intersection : show items common to both sets 
    }
}
