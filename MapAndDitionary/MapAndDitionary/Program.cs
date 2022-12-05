using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MapAndDitionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var Map2 = new Dict<int, string>();

            Map2.Add(new Item<int, string>(1, "Один"));
            Map2.Add(new Item<int, string>(2, "Два"));
            Map2.Add(new Item<int, string>(3, "Три"));
            Map2.Add(new Item<int, string>(4, "Четыре"));
            Map2.Add(new Item<int, string>(5, "Пять"));

            Map2.Show();

            Console.WriteLine(Map2.Search(5));

            Map2.Remove(3);

            Map2.Show();

            Map2.Remove(1);

            Map2.Show();

            Map2.Remove(5);

            Map2.Show();

            Map2.Remove(6);
            Map2.Show();


            Console.WriteLine("--------------------------------------------------------");

            var easyMap = new EasyMap<int, string>();

            easyMap.Add(new Item<int, string>(1, "Один"));
            easyMap.Add(new Item<int, string>(2, "Два"));
            easyMap.Add(new Item<int, string>(3, "Три"));
            easyMap.Add(new Item<int, string>(4, "Четыре"));
            easyMap.Add(new Item<int, string>(5, "Пять"));

            Console.WriteLine(easyMap.Search(5));


            foreach (var item in easyMap)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(easyMap.Search(7));

            easyMap.Remove(3);

            foreach (var item in easyMap)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();

        }
    }
}
