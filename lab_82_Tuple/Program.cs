using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_82_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new OverLOADING();
            d.DoThis1("hi");
            d.DoThis1(10);



            Console.WriteLine($"AlsoDoThis = {AlsoDoThis()}");
            int output = AndThis(out string y);
            Console.WriteLine($"AndThis = {output,-5},{y}");


            //Default way 
            //var output2 = TupleThis();
            //Console.WriteLine(output2.item1);
            //Console.WriteLine(output2.item2);



            //Best way to tuple!
            var output3 = TupleThisAlso();
            Console.WriteLine(output3.NumberA);
            Console.WriteLine(output3.StringB);

            var output4 = null ?? "hi";     //returns hi
            var output5 = "data" ?? "hi";   //returns data 

            var somedatafromdb = "some data";
            var output6 = somedatafromdb ?? "Default value";
        //    if data is null, will assign default value
            



        }
        static void DoThis()
        {
            Console.WriteLine("im doing nothing");
        }
        static int AlsoDoThis()
        {
            return -1;
        }

        static int AndThis(out string y)
        {
            y = "returning this string";
            return -100;
        }

         
        /// ///////////////////////////
  
        static (int, string) TupleThis()
        {
            return (22, "text");
        }

        static (int NumberA, string StringB) TupleThisAlso()
        {
            return (33, "more text");
        }



        /////////////////////////////////////////////
    }
    class OverLOADING {
        public void DoThis1(string y)
        {
            Console.WriteLine("hi");
        }
        public void DoThis1(int x)
        {
            x++;
            Console.WriteLine(x);
        }
    }
}
