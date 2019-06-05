using System;
using System.IO;
using System.Text; //encoding 
using static System.Console;

namespace lab_85_streaming
{
    class Program
    {
        static void Main(string[] args)
        { //creating a new file with data
            string[] data = new string[] { "some", "data", "here" };
            File.WriteAllLines("file.txt", data);
            File.AppendAllLines("file.txt", data);
            File.AppendAllText("file.txt", "some extra data\n");
            File.AppendAllText("file.txt", DateTime.Now.ToString());
            // several ways to read a file and determine a file has been read 


            //first way to code
            var reader01 = new StreamReader("file.txt"); 
           
            string output = null;
            while ((output = reader01.ReadLine()) != null)
            {
                Console.WriteLine(output);
            }




            //second way to code 
            var reader02 = new StreamReader("file.txt");

            while(!reader02.EndOfStream)
            {
                Console.WriteLine(reader02.ReadLine());
            }




        }
    }
}
