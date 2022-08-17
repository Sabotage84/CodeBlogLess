using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Анонимный тип 

            var item = new { Name = "Ivan", Age = 22 };
            Console.WriteLine(item);
            Console.WriteLine(item.Name);

            var Name = "v2";
            var Age = 22;
            //тоже корректно
            var item2 = new { Name, Age };
            //анонимные типы не должны выходить за пределы класса

            Console.ReadLine();
        }
    }
}
