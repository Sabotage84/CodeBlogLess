using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_9
{
    class Program
    {
        static int value = 0;
        static void Main(string[] args)
        {
            MyMeth(); //простой вызов метода все параметры по умолчанию
            MyMeth(8, "X");//первые параметры по очереди заданы при вызове
            MyMeth(7, g: Guid.NewGuid(), dt: DateTime.Now);//в разнобой поименно
            MyMeth(value++, value++.ToString());//пример не очевидного пост инкремента
            Console.WriteLine(value);//и далее
            MyMeth(s: (value++).ToString(), x: value++);//и далее
            Console.WriteLine(value);//и далее
            Console.ReadKey();


        }
        public static void MyMeth(int x = 9, string s="A", DateTime dt=default, Guid g =new Guid())
        {
            Console.WriteLine($"x = {x}, s = {s}, dt = {dt}, guid = {g}");
        }
    }
}
