using System;

namespace lab_57_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            var D = new Dog(100);
         //   Growing(D);
            var s = new Spaniel();
            s.Height = 100; 

        }
        /*
        static void Growing(Dog dog)
        {
            dog.Height++;
        }
        */

    }
    class Dog
    {
        public int Height { get; set; }
        public int Length { get; set; }
        protected int Weight { get; set; }
        private int _age { get; set; }

        public Dog(int Height)
        {
            this.Height = Height;
        }
    }
    class Spaniel : Dog
    { 
        public Spaniel()
        {
             
        }
    }
}
