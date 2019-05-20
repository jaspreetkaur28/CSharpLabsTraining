using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace homework_15_ASCII
{
    class Program
    {
        static List<int> list = new List<int>();
        static void Main(string[] args)
        {
            /*  Char
           Output character 'h' and its corresponding ASCII number (convert the character to an integer)
           */
            char H = 'h';
            Console.WriteLine((int)H);
            //String - Get the user to type in a message as an input string.Print out each letter of this string in turn using foreach (char c in myString) ...


            string Message;

            Console.WriteLine("Enter your message: ");
            Message = Console.ReadLine();

            foreach (var item in Message)
            {
                Console.WriteLine(item);
            }

            //  DateTime - Create today's date then go back 100 years, and then also add 10 seconds and print out the date
            //  Print out the date in several formats eg DDMMYY, DD-MMM - YYYY, as an integer number of seconds since time zero, etc.

            var e = DateTime.Today;
            var ee = DateTime.Today.ToString("dddd, dd MMMM yyyy"); ;
            Console.WriteLine(e);
            e = e.AddSeconds(10);
            e = e.AddYears(-100);
            Console.WriteLine(e);

            Console.WriteLine(ee);

            //Stopwatch -Count to 1 million and measure the time it takes

            var s = new Stopwatch();
            int total = 0;
            s.Start();
            for (int i = 0; i < 1000000; i++)
            {
                total += i;
            }
            s.Stop();
            Console.WriteLine($"Counting took {s.Elapsed}");


            // Loops - Create a for loop, foreach loop over an array, while loop and do ..while loop.Make all the loops just three items.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            string word = "Hello";
            foreach (var item in word)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("While");
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine($"while loop number is {counter}");
                counter++;
            }


            //Arrays vs Lists -   Put all the numbers from 1 to 1 million 
            //into an array and also into a list.Time how long it is to fill the array then print out every number from the array.Repeat for the list.
            

            var ss = new Stopwatch();
            int total2 = 0;
            ss.Start();

            for (int i = 0; i < 1000000; i++)
            {
                list.Add(total2 += i);
            }
            ss.Stop();
            Console.WriteLine($"Counting for the LIST took {ss.Elapsed}");




            var sss = new Stopwatch();
            int[] array01 = new int[1000000];
            int total3 = 0;
            sss.Start();

            for (int i = 0; i < array01.Length; i++)
            {
                total3 += i;
            }
            sss.Stop();
            Console.WriteLine($"Counting for the Array took {sss.Elapsed}");




            #region Array vs List (Attempts to see what went wrong)
            // Collections - Put 5 numbers into an array, then into a queue, list, stack, 
            //arraylist, dictionary and hashset.Check out the code for arraylist and hashset 
            //online.Each time you move a number add one.Return the final total of the numbers
            //in the hashset.
            int[] array02 = new int[5] { 1, 1, 1, 1, 1 };
            Queue<int> queue01 = new Queue<int>();
            List<int> list01 = new List<int>();
            Stack<int> stack01 = new Stack<int>();
            ArrayList ArrayList = new ArrayList();
            Dictionary<int, int> Dictionary = new Dictionary<int, int>();

            foreach (var item in array02)
            {
                queue01.Enqueue(item);
            }
            while (queue01.Count > 0)
            {
                list01.Add(queue01.Dequeue());
            }
            foreach (var item in list01)
            {
                stack01.Push(item);
            }

            //for (int i = 0; i < stack01.Count; i++)
            //{
            //    ArrayList.Add(stack01.Pop());
            //}
            foreach (var item in stack01)
            {
                ArrayList.Add(item);
            }

            for (int i = 0; i < ArrayList.Count; i++)
            {
                object obj = ArrayList[i]; // unboxing 
                int AL = (int)obj;
                Dictionary.Add(i, AL);
            }

 
            int total4 = 0;
            foreach (var key in Dictionary.Keys)
            {
                total4 += Dictionary[key];
            }
            Console.WriteLine(total4);

            #endregion



        }
    }

    public class Collection {


        public static int CollectionForTest(int a, int b, int c, int d, int e)
        {


            // Collections - Put 5 numbers into an array, then into a queue, list, stack, 
            //arraylist, dictionary and hashset.Check out the code for arraylist and hashset 
            //online.Each time you move a number add one.Return the final total of the numbers
            //in the hashset.

            int[] array02 = new int[5] { a, b, c, d, e };
            Queue<int> queue01 = new Queue<int>();
            List<int> list01 = new List<int>();
            Stack<int> stack01 = new Stack<int>();
            ArrayList ArrayList = new ArrayList();
            Dictionary<int, int> Dictionary = new Dictionary<int, int>();
            HashSet<int> Hashset01 = new HashSet<int>();
             
            foreach (var item in array02)
            {
                queue01.Enqueue(item);
            }
            while (queue01.Count > 0)
            {
                list01.Add(queue01.Dequeue());
            }
            foreach (var item in list01)
            {
                stack01.Push(item);
            }
            foreach (var item in stack01)
            {
                ArrayList.Add(item);
            }
            
            for (int i = 0; i < 5; i++)
            {
                object obj = ArrayList[i]; // unboxing 
                int AL = (int)obj;
                Dictionary.Add(i, AL);  
            }


            int total5 = 0; 
            foreach (var key in Dictionary.Keys)
            {
                total5 += Dictionary[key];  
            }
            //add hashset when this is fixed 
            return total5;


            //Tests- Create a test to check your collections code works as planned.


        }
    }

}
