using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_106_InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Animal("Woof", 3);
           
            a.DoThis(10);
            a.DoThis("Hi");

            var c = new Cat();
            c.UseME();

            int[] myArray = new int[3] { 1, 2, 3 };
            string[] myArray2 = new string[2] { "hello", "hi" };
            char[] myArray3 = { 'd', 'h', 'a' };
            Console.WriteLine(myArray3[0]);
            Console.WriteLine(myArray3);



            char[] array = new char[3] { 'h', 'e', 'l'};

            char c02 = array[0];
            var result = ((int)c02);
            Console.WriteLine(result);

 


            string[] array3 = new string[1] { "hello" };
          
            int x = Convert.ToInt32(array3[0]);
            var resultw = (int)x;
            Console.WriteLine(resultw);

            
        }
    }
    public class ASCIIx
    {
        public int stringnumbers(char input, int index)
        {
               
            char[] array = new char[1] {input};

            char c02 = array[index];
            var result = ((int)c02);


            return result;

        }
    }
    public class ASCII2x
    {
        public int stringnumbers(string input, int index)
        {
            var a = input[index]; // asking for the letter via array
            var ans = (int)a; // casting (changing to int value) //ascii
            //can make it shorter by using var ans = (int)input[index];
            return ans;
             
        }
    }

    interface interface1
    { 
        void UseME();
    }
    class Animal
    {
        public string Name { get; set; }
        public int Age;

        public Animal(string NAme, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public Animal() { }
        public void DoThis(int x) { }
        public void DoThis(string y) { }

    }
    sealed class Cat : Animal, interface1 {
        public void UseME() { }
    }
 

abstract class Holiday
    {
        abstract public void ThisMethod();  // no code body implementation
    }

}
