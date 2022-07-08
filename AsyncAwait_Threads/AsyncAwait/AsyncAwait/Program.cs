using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {

            DoWorkAsync();

            DoWork2Async(int.MaxValue);

            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;
                if (j % 100000 == 0)
                {
                    Console.WriteLine("MAin");
                }
            }
            Console.ReadKey();
        }

        static async Task DoWorkAsync()
        {
            await Task.Run(() => DoWork());
        }

        static async Task DoWork2Async(int i)
        {
            await Task.Run(() => DoWork2(i));
        }

        static void DoWork()
        {
            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;
                if (j % 100000 == 0)
                {
                    Console.WriteLine("DoWork");
                }
            }
        }

        static void DoWork2(object o)
        {
            int j = 0;
            for (int i = 0; i < (int)o; i++)
            {
                j++;
                if (j % 100000 == 0)
                {
                    Console.WriteLine("DoWork  2 2 2");
                }
            }
        }
    }
}
