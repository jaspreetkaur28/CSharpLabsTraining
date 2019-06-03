using System;
using System.Linq;

namespace project_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
   public class linq
    {
        public static string[] LINQunion(string[] ar1, string[] ar2)
        {
            return ar1.Union(ar2).ToArray();
        }

    }
}

