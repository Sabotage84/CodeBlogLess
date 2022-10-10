using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //минимальное и максимальное значение
            Console.WriteLine(Char.MinValue);// \0
            Console.WriteLine(Char.MaxValue);// ?

            Console.WriteLine((int)Char.MinValue);
            Console.WriteLine((int)Char.MaxValue);

            //категории
            //UnicodeCategory.
            char symbol = 'A';

            Console.WriteLine(char.GetUnicodeCategory(symbol));// upper case latter
            //можно задавать проверки

            if (char.IsLetter(symbol))
            {
                Console.WriteLine("Letter");
            }
            else
            {
                Console.WriteLine("Not letter!");
            }

            //сравнение

            var s1 = 'µ';
            var s2 = 'μ';

            Console.WriteLine('µ'.Equals(s1)); //true
            Console.WriteLine(s1.Equals(s2)); //false сравнивается код а не похожесть

            //преобразование

            var str = "CB";
            var str2 = "F";

            //var res1 = char.Parse(str); //ошибка строка должна состоять из 1 символа
            var res2 = char.Parse(str2);
            Console.WriteLine(res2);

            if (char.TryParse(str, out char result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error!");
            }

            //цыфры

            var three = char.GetNumericValue('\u0033'); // цифра 3
            Console.WriteLine(three); // 3
            Console.WriteLine((int)'\u0033');

            var quarter = char.GetNumericValue('\u00bc'); // дробь одна четвертая ¼
            Console.WriteLine(quarter); // 0.25
            Console.WriteLine((int)'\u00bc');

            var letter = char.GetNumericValue('a'); // не число
            Console.WriteLine(letter); // -1
            Console.WriteLine((int)'a');


            Console.ReadKey();
        }
    }
}
