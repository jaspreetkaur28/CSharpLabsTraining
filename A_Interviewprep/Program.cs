using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Interviewprep
{
    class Program
    {
        static void Main(string[] args)
        {


            // reversing string  and palindrome
            string x = "qwerewdq";
            string reverse = String.Empty;
            for (int i = x.Length - 1; i >= 0; i--)
            {

                reverse += x[i];
            }
            if (reverse == x)
            {
                Console.Write(reverse + " is a palindrome");
            }
            else { Console.WriteLine(reverse + "    and     " + x + "   are not palindrome"); }


            //removing spaces in a string via replace()
            string y = "hello I am Space";
            
            Console.WriteLine(y.Replace(" ", ""));

            //substrings









        }

    }
}
