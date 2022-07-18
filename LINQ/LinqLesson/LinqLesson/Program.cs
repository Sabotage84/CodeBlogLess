using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();

            for (int i = 0; i < 10000; i++)
            {
                lst.Add(i);
            }
            var result = from item in lst
                         where item < 500
                         select item;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
