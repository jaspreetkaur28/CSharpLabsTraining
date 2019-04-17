using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11_data_types
{
    class Program
    {
        static void Main(string[] args)
        {

            string x ="hi ";
            string y = "there";
            //use lowercase 'string'
            // uppercase String is when use String as a 'class'

            //Concatenate
            Console.WriteLine(x+y);

            //super-long strins this is a memory inefficient
            // stringbuilder: use to build very long strings 
            var longString = new StringBuilder(); // makes building it fast!!
            for (int i=0; i <16; i++)
            {
                longString.Append("Adding " + i);
            }
            Console.WriteLine(longString);


            //Integers are 32 bits long
        //    int anyNumber = 23456;
           // Console.WriteLine(anyNumber.GetType());

            Console.WriteLine("Integer maximum values ");
            Console.WriteLine($"2^32 is {Math.Pow(2,32)}");

            Console.WriteLine($"Max and min values {int.MaxValue}" +
                $"{int.MinValue}");

            //But these values only go to positive and negavtive values 
            //so if its 4 billion then it would be -2bil and + 2bil


            //SHORT 
           // short s = 12345;
            //INT
          //  int i = 1234567890;
            //LONG 
          //  long l = 1234567890123456789;

            //unsigneed integers: all positive
           // ushort ushort1 = 123; // of this had a neg number.. it would show a red line
            //uint
           // ulong


        }

    }
}
