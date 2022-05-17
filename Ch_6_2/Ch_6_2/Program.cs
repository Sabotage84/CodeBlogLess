using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // SomeStaticClass(6);
            B bb = new B();
            bb.Update();

            A ba = new B();
            ba.Update();

            Console.ReadKey();

        }
    }
}
