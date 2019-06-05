using System;
using System.IO;  

namespace lab_86_await_streaming
{
    class Program
    {
        static void Main(string[] args)
        {   //creating a new file with data
            string[] data = new string[] { "some", "data", "here" };
            File.WriteAllLines("file.txt", data);
            File.AppendAllLines("file.txt", data);
            File.AppendAllText("file.txt", "some extra data\n");
            File.AppendAllText("file.txt", DateTime.Now.ToString());
            for (int i = 0; i < 10; i++)
            {

                File.AppendAllText("file.txt", "A\n");
            }


            //Asynchronous method can take a long time 
            ReadFileAsync();
            Console.WriteLine("program has finished");
            Console.ReadLine();
        }
        static async void ReadFileAsync()
        {
            //To make this Asynchronous we have to add the async keyword

            //just for illustration for the async method - not what we wanted to achieve
            //string output = await File.ReadAllTextAsync("file.txt");
            //Console.WriteLine(output);




            //use StreamReader
            using(var reader = new StreamReader("file.txt"))
            {
                while (true)
                {
                    string oneLine = await reader.ReadLineAsync();
                    if (oneLine == null) { break; }
                    Console.WriteLine(oneLine);
                }
            }

        } 
    
    }
}
