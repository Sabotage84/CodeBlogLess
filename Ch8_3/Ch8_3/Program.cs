using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, world!";

            str.Print();//используем метод расширения

            Action ac = str.Print;

            ac();//можно вызвать через делегат

            Console.ReadLine();

        }
    }
}
