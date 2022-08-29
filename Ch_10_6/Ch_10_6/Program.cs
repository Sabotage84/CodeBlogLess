using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_10_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var vt1 = (1, "Value", "Tuple");

            Console.WriteLine(vt1.Item2+" " + vt1.Item3);
            Console.WriteLine();

            ValueTuple<int, string, string> vt2 = (1, "Value", "Tuple 2");
            Console.WriteLine(vt2.Item2 + " " + vt2.Item3);
            Console.WriteLine();




            Console.ReadLine();


        }
    }
}
