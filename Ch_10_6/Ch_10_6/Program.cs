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


            (int ID, string Name) vt3 = (1, "Value Type 3");
            Console.WriteLine(vt3.ID+" - "+vt3.Name);

            var vt4 = (ID: 2, Name: "Value Type 5");
            Console.WriteLine(vt4.ID + " - " + vt4.Name);

            Console.ReadLine();


        }
    }
}
