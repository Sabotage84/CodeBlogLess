using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
namespace Ch_10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var explTuple = new Tuple<int, int, int>(1,10, 15);
            Console.WriteLine(explTuple.Item1);//не читаемо

            var tuple2 = Tuple.Create(1, 2, 3, "Ivan");

            //другой подход более удобно читать но динамик-риск
            dynamic e = new ExpandoObject();
            e.x = 3;
            e.y = 5;
            e.name = "EO";



            Console.ReadLine();
        }
    }
}
