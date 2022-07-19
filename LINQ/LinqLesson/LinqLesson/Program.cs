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

            for (int i = 0; i < 1000; i++)
            {
                lst.Add(i);
            }
            var result = from item in lst
                         where item < 500
                         select item;

            var result2 = lst.Where(item => item % 2 == 0);

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
