using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_3
{
    public static class MyExtensions
    {
        public static void Print<T>(this IEnumerable<T> lst)//метод расширения для интерфейса
        {
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }

    }
}
