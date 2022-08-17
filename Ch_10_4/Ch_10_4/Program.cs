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

            Console.WriteLine(item.Name);
            Console.ReadLine();
        }
    }
}
