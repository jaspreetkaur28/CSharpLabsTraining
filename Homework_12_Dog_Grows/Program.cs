using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_Dog_Grows
{ /*Test 1
    Create Dog Class and Grow() method : check when you call this the Age increases by one year and the height increases by 5 as well
*/
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    public class Dog
    {
        public int Age { get; set; }
        public int Height { get; set; }
         
        public int Grow( out int height) {


            height = -1;
            return -1;
        }
        public int Growing(int a, int h)
        {
            a = Age++;
            h = Height += 5;
              
            return a + h;
        }
    }
}
