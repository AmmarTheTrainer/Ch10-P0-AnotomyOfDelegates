using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_P0_AnotomyOfDelegates
{
    //public delegate string MyDelegate(bool a, bool b, bool c);

    public delegate string MyOtherDelegate(out bool a, ref bool b, int c);

    class Program
    {
        static void Main(string[] args)
        {
            //MulticastDelegate


        }
    }

    //class MyClass : MulticastDelegate
    //{

    //}
}
