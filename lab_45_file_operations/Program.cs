using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_45_file_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a new file if there isnt one or rewrites all the existing data
           // File.WriteAllText("file2.txt", "some data");


            Console.WriteLine("\n\nRead raw data"); //\n\n adding spaces between the cw paragraphs
            string data = File.ReadAllText("file.txt");
            Console.WriteLine(data);

           //Write data 
            Console.WriteLine("\n\nWriting Data");
            File.WriteAllText("file.txt", "Hello");

            //Reads and shows the new data 
            Console.WriteLine("\n\nReading it back ");
            data = File.ReadAllText("file.txt");
            Console.WriteLine(data);
            //


//View original data and adds in the new  new data with the timestamp for the last row
            Console.WriteLine("\n\nAppending text");
            File.AppendAllText("file.txt", Environment.NewLine + "data 1"); //Environment puts the new data on a new line 
            File.AppendAllText("file.txt", Environment.NewLine + "data 2");
            File.AppendAllText("file.txt", Environment.NewLine + "data 3");
            File.AppendAllText("file.txt", Environment.NewLine + "data 4 " + DateTime.Now.ToString());// or can show with datetime
            File.AppendAllText("file.txt", Environment.NewLine + "SearchingTerm22");
            data = File.ReadAllText("file.txt");
            Console.WriteLine(data);

//view original data with timestamp at the botttom - uses the appendtext above for next 
            Console.WriteLine("\n\nLogging with data time stamp");
            File.AppendAllText("file.txt", Environment.NewLine + DateTime.Now.ToString());
            // DateTime.Now is also acceptable - doesnt need it.
            data = File.ReadAllText("file.txt");
            Console.WriteLine(data);


            //reading multiple lines to an arry 
            Console.WriteLine("\n\nSearching text file for a term");
            string[] dataArray = File.ReadAllLines("file.txt");
            foreach(string item in dataArray)
            {
                if (item== "SearchingTerm22")
                {
                    Console.WriteLine("Found it!");
                }
            }
            for (int i = 0; i<dataArray.Length;i++)
            {
                if (dataArray[i] == "SearchingTerm22")
                {
                    Console.WriteLine("BINGO. Found at line " + i);
                }
            }




    //File.Copy (true means year overwrite if it exists) 
            // File.Copy("file.txt", "filecopy.txt", true);
    //makes a copy called filecopy

    //deletes file.txt
            // File.Delete("file.txt");

    //Moves the file to another file / or changes its name (new path)
          /*  if (!File.Exists("file.copynewname.txt"))
            {
                File.Move("file2.txt", "filecopynewname.txt");
            }
            */
            Console.WriteLine(File.GetCreationTime("file.txt"));
            Console.WriteLine(File.GetLastWriteTime("file.txt"));

            //Create folders
            Directory.CreateDirectory("Parent");
            Directory.CreateDirectory("Parent\\Child1");
            Directory.CreateDirectory("Parent\\Child2");
            Directory.CreateDirectory("Parent\\Child3"); //folder child inside Parent
            File.WriteAllText("Parent\\Child2\\file.txt", "Hello"); //creates a file with data inside
            //Delete one
            Directory.Delete($"Parent\\Child3", true);

            //Create new folder in c:\drive 
            //          Directory.CreateDirectory("\\TestFolder");
            //Create in MyDocuments
            //         Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TestFolder");


            //list all files in folder and see if one file exists!!
            /* lab: 
             * 
             * 
             */
            //Create in MyDocuments
            var MyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Directory.CreateDirectory((MyDocuments) + "\\LabFile");
            
            var filelist = (Directory.EnumerateFiles(MyDocuments) + "\\LabFile");

           //  var bobisthere = false; 
            foreach (var item in filelist)
            {
                Console.WriteLine((MyDocuments) + "\\LabFile");
                Console.WriteLine(item);
                if (item ==   MyDocuments + "\\LabFile\\bobfile.txt")
                {
                    //bobisthere = true;
                    Console.WriteLine("bob is there");
                } else Console.WriteLine("no bob");
            }
           


        }

    }
}
