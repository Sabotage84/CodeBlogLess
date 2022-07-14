using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMeth
{
    class Program
    {
        delegate int MyHandler(int x);
        static void Main(string[] args)
        {
            int r = 7;

            MyHandler handler = delegate (int i)
             {
                 Console.WriteLine(i * i);
                 return i * i;
             };

            handler += MyMeth;
            
            handler(r);
            Console.ReadLine();
        }

        static int MyMeth(int i)
        {
            Console.WriteLine(i * i*i);
            return i * i * i;
        }
    }
}
