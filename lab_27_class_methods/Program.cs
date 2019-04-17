using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_27_class_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var car01 = new Mercedes();
            car01.Speed = 10;
            //var increasedSpeed = car01.Accelerate();
            // Console.WriteLine(increasedSpeed); Both these codes are longer versions of writing the following below

            Console.WriteLine(car01.Accelerate());
            Console.WriteLine(car01.Accelerate());
        }

        class Mercedes
        {
            public int Speed;
            public int Accelerate ()
            {
                Speed++;
                return Speed;
            }
        }

    }
}
