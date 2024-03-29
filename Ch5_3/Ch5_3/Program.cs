﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 1);

            Console.WriteLine(p);//(1,1)  boxing так как writeline принимает ссылочный тип

            p.Change(2, 2);
            Console.WriteLine(p);//(2,2)  boxing так как writeline принимает ссылочный тип, а предыддущий уже уничтожен

            object o = p;//boxing 
            Console.WriteLine(o);//(2,2)  

            ((Point)o).Change(3, 3);//unboxing 
            Console.WriteLine(o);//(2,2) так как в o не записалось ничего, мы разбоксили сделав новый объект в стеке и потом вернулись к тому что в куче

            //решение
            ((IChangePoint)o).Change(3, 3);
            Console.WriteLine(o);//(3,3)

            //такие же проблемы возможны и с unboxing
            ((IChangePoint)p).Change(5, 5);
            Console.WriteLine(p);//(2,2)

            dynamic d1 = 5;
            dynamic d2 = "S";

            dynamic res1 = Plus(d1);
            dynamic res2 = Plus(d2);

            Print(res1);
            Print(res2);


            Console.ReadLine();
        }

        static dynamic Plus(dynamic arg)
        {
            return arg + arg;
        }

        static void Print(int i)
        {
            Console.WriteLine($"int {i}");
        }

        static void Print(string s)
        {
            Console.WriteLine($"string {s}");
        }

    }
}
