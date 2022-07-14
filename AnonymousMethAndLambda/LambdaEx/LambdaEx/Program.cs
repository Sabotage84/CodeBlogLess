using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEx
{
    class Program
    {
        static void Main(string[] args)
        {

            Lesson ls = new Lesson("Test lambda");

            ls.Started += (sender, date) =>
              {
                  Console.WriteLine(sender);
                  Console.WriteLine(date);
              };


            ls.Start();



            List<int> lst = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                lst.Add(i);
            }

            var res = lst.Aggregate((x, y) => x + y);
            Console.WriteLine(res);





            Console.ReadLine();
        }
    }
}
