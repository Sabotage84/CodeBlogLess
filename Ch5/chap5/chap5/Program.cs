﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap5
{
    class Program
    {
        static void Main(string[] args)
        {
            //приведение типов переполнение
            int i = 5;
            long l = i; //все норм, неявное приведение
            // int j = l; //ошибка, возможно переполнение
            int j = (int)l; //все ок, явное приведение на совести программиста
        }
    }
}
