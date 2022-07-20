using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lst = new List<Product>();


            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                var p = new Product { Name = "Продукт " + i, Energy = rnd.Next(10, 500) };

                lst.Add(p);
            }
            var result = from item in lst
                         where item.Energy < 100
                         select item;

            var result2 = lst.Where(item => item.Energy % 2 == 0);

            var result3 = lst.Where(item => item.Energy % 2 == 0).Where(x=>x.Energy%5==0).OrderByDescending(item=>item);


            foreach (var item in result3)
            {
                Console.WriteLine(item.Name + "   "+ item.Energy);
            }
            Console.ReadKey();
        }
    }
}
