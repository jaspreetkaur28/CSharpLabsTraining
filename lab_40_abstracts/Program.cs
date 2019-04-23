using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_40_abstracts //abstact class
{
    class Program
    {
        static void Main(string[] args)
        {
            //  var h = new Holiday(); //No actually plans and code so cant do this 
            var h = new LetsGo(); // this class has travel plans 

        }
    }
    abstract class Holiday
    {
        //REAL METHOD
        void VisitGeysers() { }


        //ABSTRACT METHOD 
        abstract public void GettingToIceland();
    }
    class LetsGo : Holiday
    {
        public override void GettingToIceland()
        {
            //yes we do travel by plane and hire a car
        }
    }
}
