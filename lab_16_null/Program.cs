using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_16_null
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = null; //absent of data
            string y = "";
            Console.WriteLine(x==y); // FALSE. dont equal each other

            //If read from the database and there is literally no data coming in , then thats a 'null'

            //integer set default value = 0 
            int z = new int();
            Console.WriteLine(z); // returns 0 as it's the default. 

// copy info from todays notes - Scenerio*

            int? zz =0; 
            zz = null;

            int? num1 = null; // called a nullable integar - doesnt like it
        }
    }
}
