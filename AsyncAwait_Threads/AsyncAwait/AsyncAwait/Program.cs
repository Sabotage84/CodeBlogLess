using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {

            //DoWorkAsync();

            //DoWork2Async(int.MaxValue);

            //int j = 0;
            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    j++;
            //    if (j % 100000 == 0)
            //    {
            //        Console.WriteLine("MAin");
            //    }
            //}

            var result = SaveFileAsync("d:\\test.txt");
            var input = Console.ReadLine();
            Console.WriteLine(result.Result);
            


            Console.ReadLine();
        }


        static async Task<bool> SaveFileAsync(string path)
        {
            var result = await Task<bool>.Run(() => SaveFile(path));
            return result;
        }

        private static bool SaveFile(string path)
        {

            var rnd = new Random();
            var str = "";
            for (int i = 0; i < 50000; i++)
            {
                str += rnd.Next();
            }

            using (var sr = new StreamWriter(path, false, Encoding.UTF8))
            {
                sr.WriteLine(str);
            }

            return true;
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
