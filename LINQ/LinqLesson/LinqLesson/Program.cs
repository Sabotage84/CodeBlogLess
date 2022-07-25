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
            for (int i = 0; i < 100; i++)
            {
                var p = new Product { Name = "Продукт " + i, Energy = rnd.Next(60, 100) };

                lst.Add(p);
            }
            var result = from item in lst
                         where item.Energy < 100
                         select item;

            var result2 = lst.Where(item => item.Energy % 2 == 0);

            var result3 = lst.Where(item => item.Energy % 2 == 0).Where(x=>x.Energy%5==0).OrderByDescending(item=>item);

            var res4 = lst.Select(p => p.Energy);

            var result5 = lst.Where(item => item.Energy % 2 == 0).Where(x => x.Energy % 5 == 0).OrderByDescending(item => item.Energy).ThenBy(x=>x.Name);


            foreach (var item in result5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            var groupCollection = lst.GroupBy(p => p.Energy);
            foreach (var group in groupCollection)
            {
                foreach (var item in group)
                {
                    Console.WriteLine(group.Key + "  ->  "+item);
                }
            }

            Console.WriteLine(lst.All(p=>p.Energy==90));
            Console.WriteLine(lst.Any(p => p.Energy == 90));

            var array = new int[] { 1, 2, 3, 4 };
            var array2 = new int[] { 3, 4, 5, 6, 7, 8 };

            var unionArray = array.Union(array2);

            foreach (var item in unionArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var intersectArray = array.Intersect(array2);

            foreach (var item in intersectArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var ex = array.Except(array2);

            foreach (var item in ex)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
