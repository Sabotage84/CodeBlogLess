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
        int l;
        int k;
    }
}
