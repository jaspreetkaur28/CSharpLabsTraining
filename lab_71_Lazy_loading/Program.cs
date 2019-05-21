using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_71_Lazy_loading
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[3] { 1, 2, 3 };
            //IEmnumberable 
            var output =
                from item in array
                select item;
            //lazy loading so query not actually run yet 
            // prove this by updating the array first 

            array[1] = 20000000;

            //now let's read the query 
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            //force query to run immediately (immdeiate execution) .ToList() or similar 
            //also if output just a scalar number e.g output.count ==>run immediately 
             
        }
    }
}
