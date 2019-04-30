using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_55_revision
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 3D arrays
            int[] array1D = new int[] { 10, 20, 30 }; //literal - you literally put code into it
            var arrary1Da = new int[10];
            Console.WriteLine(arrary1Da[0]);
            Console.WriteLine(arrary1Da[arrary1Da.Length - 1]); //asks for the last number in array no matter the length 

            int[,] array2D = new int[5, 5]; //5x5 grid 
            //what would be the code for 2nd row and 3rd column?  so arrary 1 and 2
            Console.WriteLine(array2D[1, 3]);

            int[,,] array3D = new int[5, 5, 5]; //5x5 grid 
            //what would be the code for 3nd row and 4rd column and height of 5?  so arrary 2,3,4
            Console.WriteLine(array3D[2, 3, 4]);
            #endregion


            #region BASIC LAYOUT for OOP part 1
            //We can create millions of dogs now
            var d1 = new Dog();
            d1.Bark();
            d1.Age = 5;

            Console.WriteLine(Dog.numLegs); //4 // static so has to be calls with class name.
            //DogFactory
            List<Dog> doglist = new List<Dog>();
            for (int i = 0; i < 100000; i++)
            {
                doglist.Add(new Dog());
                //or
                var d = new Dog();
                d.Age = 4;
                doglist.Add(d);
            }
            #endregion

        }
        #region BASIC LAYOUT for OOP part 2
        class Dog // class is a blueprint for creating dogs(objects which we call dog)
        {
            
            public static readonly  int numLegs = 4; // static and doesnt change.
            public int Age { get; set; } //instance field

            public void Bark() { } //instance method
        }
        #endregion

    }
}
