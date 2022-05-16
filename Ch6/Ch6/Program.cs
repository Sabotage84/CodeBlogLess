using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass sm = new SomeClass();
            int i = 1;
            string s = "00";

            var t = i + s;

            Console.WriteLine(sm["lala"]);

            Console.ReadKey();
        }
    }
}
