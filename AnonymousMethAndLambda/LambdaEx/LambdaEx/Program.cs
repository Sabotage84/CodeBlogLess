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


            Console.ReadLine();
        }
    }
}
