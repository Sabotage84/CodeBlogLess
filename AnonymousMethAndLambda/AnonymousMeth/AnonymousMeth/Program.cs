using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMeth
{
    class Program
    {
        delegate int MyHandler(int x);
        static void Main(string[] args)
        {
            int r = 7;

            MyHandler handler = delegate (int i)//добавление анонимного метода
             {
                 Console.WriteLine(i * i);
                 return i * i;
             };

            handler += MyMeth;//добавление просто метода

            handler += (i) =>
            {
                Console.WriteLine(i * i * i * i);//Когда много строк в лямбда
                return i * i * i * i;
            };

            handler += (i) => 2 * i;//В одну строку
          

           

            Console.WriteLine( handler(r));// в делегате сохраняется результат последнего метода

            Console.ReadLine();
        }

        static int MyMeth(int i)
        {
            Console.WriteLine(i * i*i);
            return i * i * i;
        }
    }
}
