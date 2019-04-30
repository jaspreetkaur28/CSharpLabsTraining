using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_56_events
{
    class Program
    {
        //Delegate: says our event can only trigger methods which have a set pattern
        delegate void MyDelegate(); //pattern:Method must be avoid...()
        //Event now which uses this delegate
        static event MyDelegate myEvent; //create event; when it triggers any methods which must match this pattern


        static void Main(string[] args)
        {
            //Goal: replcea manually calling 3 methods with 1 event which triggers there methods 
            MyMethod01();
            MyMethod02();
            MyMethod03();

            myEvent += MyMethod01;
            myEvent += MyMethod02;
            myEvent += MyMethod03;
            //call the event 
            myEvent();
        }

        static void MyMethod01()
        {
            Console.WriteLine("do something1");
        }static void MyMethod02()
        {
            Console.WriteLine("do something2");
        }static void MyMethod03()
        {
            Console.WriteLine("do something3");
        }
    }
}
