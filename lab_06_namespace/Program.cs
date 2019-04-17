using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jaspreet1;

namespace lab_06_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new Jaspreet1.Student();
            var item2 = new Student(); // using jaspreet1 is at the top so doesnt need to be called.

            var item3 = new Jaspreet2.Learning();
            Console.WriteLine(item3.LearnLots);
        }
    }
}
namespace Jaspreet1 {
    public class Student { }
}

namespace Jaspreet2 {
    public class Learning {
        public string LearnLots = "running C#";

    }
}