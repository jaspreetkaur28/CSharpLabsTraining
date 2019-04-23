﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_31_class_with_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            p.SetHidden("hello private data");
            p.Age = 23;
            p.Height = 1500;
            Console.WriteLine(p.Height);
            p.Height = -1500;
            Console.WriteLine(p.Height);

        }
    }

    class Parent
    {
        private string _hidden; //private field 
        private double _height;
        public int Age { get; set; } // Public property :  abbreviated form
                                     //auto-implemented properties

            
       //Expanded form
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value >0)
                {
                    _height = value;
                }
                
            }
        }   // short cut  ================== public int Age { get; set; } 




        public void SetHidden(string setData)
        {
            _hidden = setData;
        }
        public string GetHidden()
        {
            return _hidden;
        }
    }
}
