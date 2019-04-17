using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_18_data_types
{
    class Program
    {
        static void Main(string[] args)
        {

            byte b = 0b10101010; //Latest c# has literal binary type

            // also use hex 0 to F ( 0 to the value of 15)
            byte bb = 0xFF; // f-15 decimal = 1111 binary 
                            // FF = 11111111 in binary 

            byte bbb = 15;


            // ASCII CODE - all symbols give a numerical value


            char c = 'f';
            Console.WriteLine(c);
            //convert  to a number string using (int) (casting)
            Console.WriteLine((int) c); // ASCII CODE FOR f


            char c02 = 'g';
            Console.WriteLine((int) c02); // 103 is the equal to g (lowercase)

            // convert number to  character
            char c03 = (char)104;
            Console.WriteLine(c03);



            // raw objects
            object o1 = 10;
            object o2 = "hi";
            object o3 = false;

            object o4 = new
            {
                name = "Bob",
                dob = "20/3/2000"
            };

            //Const

            const string DontChangeMe = "I don't change";
            //DontChangeMe = "to something else";


        }
    }
}
