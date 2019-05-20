using System;

namespace lab_59_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new child();
            c.property01 = 10; // interface property 
            c.UseThisTool02(); // interface method
        }
    }

    interface IDoThis01 {
       // private int x; // no fields allowed
       int property01 { get; set; } // no public keyword used 
        void UseThisTool02();
    }
    interface IDoThis02 {
        void UseThisTool02(); // abstract without using the keyword 
    }
    class parent { }
    class child : parent, IDoThis01, IDoThis02 {
        public int property01 { get; set; } // needs the public keyword here
         public void UseThisTool02(){ }
    }

}
