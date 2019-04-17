using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // read to files (input output)
using lab_04_dll;

namespace lab_05_use_dll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading from another library");

            var item = new JaspreetLibrary();

            item.JaspreetsData = "some data here";
            Console.WriteLine(item.JaspreetsData);
            Console.WriteLine(item.JaspreetsFixedData);


        }
    }
}
