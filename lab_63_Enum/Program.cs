using System;

namespace lab_63_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fruit.banana);
            //use the numeric value also 
            Console.WriteLine((int)Fruit.banana);
            //even add a count
            Console.WriteLine($"There are {(int)Fruit.count} types of fruits");
            //an an invaild type with -1
            // cast to int - chnages the value to an int from array


            int i = 5;
            Console.WriteLine(++i);
            Console.WriteLine(i);
            Console.WriteLine(i++);

            int x = 10; // x = 
            int y = ++x; // y = 
            Console.WriteLine(y);
            int z = y++;
            Console.WriteLine(z); // z = ?

        }
    }
    //Enum is a structure to hold values which are not expected to change, ever. 
    // days of the week, months of the year or staff codes in a company 
    enum Fruit
    {
        invalid=-1,banana,apple,pear,plum,peach,grape,count
//array    0,    1,   2,   3,    4,   5

        //they can be assigned values such as apple=1 
    }
}
