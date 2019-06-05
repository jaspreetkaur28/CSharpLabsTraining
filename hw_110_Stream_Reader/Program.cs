using System;
using System.Text;
using System.IO;

namespace hw_110_Stream_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("version1 - read.ReadLine() string is not null==");
            StreamReader reader = new StreamReader("abc.txt");
            string oneLine = null;
            while ((oneLine = reader.ReadLine()) != null)
            {
                Console.WriteLine(oneLine);
            }

            Console.WriteLine("using test for not end of stream");
            StreamReader reader2 = new StreamReader("abc.txt");
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader2.ReadLine());
            }





        }
    }

    class StreamReader2
    {
        public static (int, string) Stream_Reader_Writer_Parse(string path)
        {
            // Get path of a file
            // Use StreamReader to read the file
            int numlines = -1; // number of lines in the file
            string output = "-1";  //  output string 
            StreamReader reader = new StreamReader(path);


            string oneLine = null;
            while ((oneLine = reader.ReadLine()) != null)
            {
               var s = oneLine.Replace(' ', 'what to replace with'); 
            }



            // parse each string as you read it in and remove all spaces
            // (leading, trailing and in the middle);
            // return the raw string as one long string
            // eg
            //  text file is 
            /*
             *   hello how arepy
             *   you ? I am very
             *   
             *   
             */

            // returns (2,"hellohowareyou?Iamvery")





            return (numlines, output);  // Tuple!

        }
    }
}
