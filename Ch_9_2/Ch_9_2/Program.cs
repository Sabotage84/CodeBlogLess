using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_9_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            GetVAlue(out x);
            Console.WriteLine(x);



            int y = 7;
            AddValue(ref y);
            Console.WriteLine(y);

            Dog d = new Dog("Харлей Дэвинсон");
            Console.WriteLine(d);
            ChangeDogNAme(ref d, "Харлей");
            Console.WriteLine(d);

            Console.ReadKey();

        }

        private static void AddValue(ref int y)
        {
            y += 10;
        }

        private static void GetVAlue(out int x)
        {
            x = 10;
        }

        private static void ChangeDogNAme( ref Dog d,string s)
        {
            d = new Dog(s);
            Console.WriteLine(d);
        }
    }
}
