using System;

namespace lab_62_struct
{
    class Program
    {
        static void Main(string[] args)
        { 
                var p01 = new Point(); // default constucter hasnt gone away with the new constructor for struct
                p01.X = 10;
                p01.Y = 10;
                var p02 = new Point(10, 11); // New constructor
            }
        }

        class Parent
        {
            public int height { get; set; }
        }

        //Points on line : want very fast, not so much detail inside(x,y) 
        struct Point
        {
            public int X; // public fields, no Hiding 
            public int Y;
            public Point(int X, int Y)
            {
                this.X = X;
                this.Y = Y;
            }
        }
    }
