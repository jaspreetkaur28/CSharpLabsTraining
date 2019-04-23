using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_39_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new BaseParent();
            p.HaveAParty();
            var c = new DerivedChild();
            c.HaveAParty();
            var t = new DerivedTeenager();
            t.HaveAParty();
        }
    }
    class BaseParent
    {
        virtual public void  HaveAParty() { Console.WriteLine("Having a dinner party"); } // no static as it doesnt have a instance
        //virtual means it can be overridden by a child
    }
    class DerivedChild : BaseParent
    {
       override public void HaveAParty() { Console.WriteLine("Having a swimming Party"); }
        //states it wants to override the default parent value. - optional
    }
    class DerivedTeenager: BaseParent
    {
        override public void HaveAParty() { Console.WriteLine("Going out with friends"); }
    }
}
