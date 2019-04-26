using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_42_testme
{
    public class testme
    {
        public double BIDMAS01(int x,int y, int z)
        {
            //goal : x + y/z observing BIDMAS rules
            double Y = y;
            double Z = z;

            return x + (Y/ Z);




            //   return -1; // -1 means 'fail'
        }
    }
}
