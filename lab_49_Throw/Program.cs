using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_49_Throw
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                counter++;//Code will go on forever
                if (counter>100000)
                {
                    throw new Exception("Number is too big");
                }
            }
        }
    }
}
