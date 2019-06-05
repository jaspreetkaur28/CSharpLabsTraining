
using System;
using System.Text;
using System.IO;

namespace hw_110_StreamReaderPhils
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("== Using test for reader.ReadLine() string is not null ==");


            StreamReader reader = new StreamReader("abc.txt"); // file from the bin debug folder
            string oneLine = null; //sets it to null value
            while ((oneLine = reader.ReadLine()) != null) //if the value read from the reader not null then do this 
                                                          //(also senters the value into oneLine)
            {
                Console.WriteLine(oneLine); // prints the lines
            }

            /*
             streamReader 
             - declare it
             - set string to null
             - while loop - enter reader.readline into string while asking it it's not null
             - print string like in loop
             */







            Console.WriteLine("==using test for Not End Of Stream==");
            reader = new StreamReader("abc.txt");
            oneLine = null;
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }

            Console.WriteLine("==using test for Peek is not -1");
            int oneLetterCode;    // did you know the output from reader.read() is 
                                  //actually an integer representing the ASCII/Unicode 
                                  //number of the letter which has been stored!!!
            var char01 = new char();
            var sb = new StringBuilder();
            reader = new StreamReader("abc.txt");
            while (reader.Peek() != -1)
            {
                oneLetterCode = reader.Read();
                Console.WriteLine(oneLetterCode);
                char01 = (char)oneLetterCode;
                Console.WriteLine(char01);
                Console.WriteLine("--");
                sb.Append(char01);
            }




        }
    }
}