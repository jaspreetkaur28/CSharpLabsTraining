using System;

namespace lab_58_constructor_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var d = new Dog();
            var d1 = new Dog(10);
            var s = new Spaniel();

            //  var s1 = new Spaniel(10); 
            // This doesnt work as Spaniel via the Dog constructor as it doesnt take 
            // the constructor from Dog class.

            d.Grow();
            s.Grow(); // METHOD IS INHERITED!

            const int Dont_change_me = 500; // varible
                                            // Dont_change_me = 300; // Doesnt allow it to be changed as it's const
                                            //d.NumLegs = 5; // Doesnt allow it as it is a read only 

            Console.WriteLine(EngineeringConstants.Constant01);
            //static class so needs to be called instead of new variable 
        }
    }
    class Dog
    {
        public int Age { get; set; }
        public readonly int NumLegs = 4; //class varible
        public Dog(int Age)
        {
            this.Age = Age;
        }
        public Dog() { }
        public void Grow() { Age++; }
    }
    class Spaniel : Dog
    {
        public Spaniel(int anyvarible)
        {
            this.Age = anyvarible;
            //anyvarible only matter this in this 
            //constructor as it's private and will only be used here. (in it's scope) 
        }
        public Spaniel() { }
    }

    static class EngineeringConstants
    {
        public static readonly double Constant01 = 2.45793;
    }
    static class Luton
    {
        public static void SayHi() { }
    }


}
