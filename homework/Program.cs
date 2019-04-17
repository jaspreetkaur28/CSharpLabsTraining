using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 1000 ; i++)
            {
                if (i % 100 == 0)
                {
                    Console.WriteLine("I am a snail");
                }

                else Console.WriteLine(i);
            }
            for (int i = 1000; i > 0; i--)
            {
                if (i % 100 == 0)
                {
                    Console.WriteLine("I am a snail");
                }

                else Console.WriteLine(i);
            }
        }
    }
}
