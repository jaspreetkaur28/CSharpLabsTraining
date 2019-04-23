using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int SquareDigits(int n)
        {
            // int n = 0;
            // Console.WriteLine("For each");
            foreach (var item in n)
            {
                int a = Math.Pow(item, 2);

                return a;
            }

        }

    }
}
