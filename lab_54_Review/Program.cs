using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_54_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 13;
            switch(x) {
                case 1:
                    Console.WriteLine("item is 1");
                    break;
                case 10:
                    Console.WriteLine("item is 10");
                    break;
                default:
                    Console.WriteLine("item is invalid");
                    break;

            }

        }
    }
}
