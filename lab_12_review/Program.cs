using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12_review
{
    class Program
    {
        static void Main(string[] args)
        {

            /*data types

            Integers are 32 bits long
            short- 16 bit long  - Int16
            long - 64 big long  - Int64
            Ushort - positive values only

            Division. Always add a decimal point to any of the values
                      so you get a remainder or it will not be includes

            Decimals have a default of DOUBLE - 64 bit precision

 Add in the var code from the lesson review notes 

            */

            //LOOPS test. 3 minutes

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int x = 0;
            while (x < 5) 
            {
                Console.WriteLine(x);
                x++;
            }

            int j = 5;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 10);


            var myarray = new string[] { "one", "two", "three" };

            foreach (string a in myarray)
            {
                Console.WriteLine(a);
            }


            String value = "Foreach Loop";
            foreach (char c in value)
            {
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}
