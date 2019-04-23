using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListQueuesStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);
            intList.Remove(10);

            Console.WriteLine(intList.Count);

            List<int> intList2 = new List<int>() { 10, 20, 30, 40 };

            Console.WriteLine(intList2.Count);

            List<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Remove("three");
            strList.Add("four");
            strList.Add("four");
            strList.Add(null);
            strList.Add(null);



            Console.WriteLine(strList.Count);


            List<Student> studentList = new List<Student>() {
                new Student(){ StudentID=1, StudentName="John"},
                new Student(){ StudentID=2, StudentName="Jane"}
            };

            Console.WriteLine(studentList.Count);




            // Here you have it - a queue of arrays
            // Really, it's no different than a queue of any other type
            Queue<int[]> queue2 = new Queue<int[]>(
                // Construct the queue from the following array of arrays
                new[]
                {
                new[] { 3, 2, 1, 0 },
                new[] { 32, 24, 234, 3 }
                // Whatever you want
                }
            );

            // If all you want is a queue with four ints, why bother with the queue of array thing?
            // You can initialize a queue with some numbers like this
            Queue<int> queueOfInts = new Queue<int>(new[] { 3, 2, 1, 0 });


            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Dequeue();



            Stack<string> myStack = new Stack<string>();

            // Inserting the elements into the Stack 
            myStack.Push("Geeks");
            myStack.Push("Geeks Classes");
            myStack.Push("Noida");
            myStack.Push("Data Structures");
            myStack.Push("GeeksforGeeks");

            // Converting the Stack into array 
            String[] arr = myStack.ToArray();

            // Displaying the elements in array 
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }















        }
    

         public class Student
         {
           public int StudentID { get; set; }
            public string StudentName { get; set; }             

         }


    }
}
