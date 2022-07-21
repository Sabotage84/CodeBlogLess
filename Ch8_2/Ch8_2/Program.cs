using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2.3, 3.1);

            Complex c2 = new Complex(1.1, 1.1);

            Complex c3 = c1 + c2;
            Console.WriteLine(c3);

            Console.ReadLine();
        }
    }
}
