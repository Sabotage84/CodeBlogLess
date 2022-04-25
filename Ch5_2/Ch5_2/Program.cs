using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5; //В стеке появляется переменная 5

            Str stru = new Str();//в стеке выделяется память под структуру 2 int X и Y

            ASMR aa = new ASMR(); //выделяет в стеке память под int и для ссылки на obj

            MyClass m = new MyClass();//создается в стеке ссылка на кучу где уже храняться L и K

            MyClass m2 = m;//ссылается тудаже куда и m при изменении одной затрагивает и другую

            DiffStructAndClass();

        }

        private static void DiffStructAndClass()
        {
            Str s1 = new Str();
            s1.x = 1;
            s1.y = 2;
            Console.WriteLine($"S1 x = {s1.x} y = {s1.y}");

            Str s2 = new Str();
            s2 = s1;
            Console.WriteLine($"S1 x = {s1.x} y = {s1.y}");
            Console.WriteLine($"S2 x = {s2.x} y = {s2.y}");

            Console.WriteLine("Inc S2");
            s2.x += 10;
            s2.y += 10;

            Console.WriteLine($"S1 x = {s1.x} y = {s1.y}");
            Console.WriteLine($"S2 x = {s2.x} y = {s2.y}");

            MyClass my1 = new MyClass();
            my1.k = 5;
            my1.l = 6;

            MyClass my2 = new MyClass();
            my2 = my1;

            Console.WriteLine($"My1 x = {my1.l} y = {my1.k}");
            Console.WriteLine($"My2 x = {my2.l} y = {my2.k}");

            Console.WriteLine("Inc my2");

            my2.k += 10;
            my2.l += 10;

            Console.WriteLine($"My1 x = {my1.l} y = {my1.k}");
            Console.WriteLine($"My2 x = {my2.l} y = {my2.k}");


            //BOXING UNBOXING

            int b = 6;

            object o = b; //boxing
            int un = (int)o;//unboxing

            //  byte bb = (byte)o;//будет ошибка во время выполнения

            byte bb = (byte)(int)o;//надо вот так


            Console.ReadKey();
        }
    }
    struct Str 
    {
        public int x;
        public int y;
    }

    struct ASMR
    {
        int b;
        object obj;
    }

    class MyClass
    {
        public int l;
        public int k;
    }
}
