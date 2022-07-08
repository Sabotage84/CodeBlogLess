using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(new ThreadStart(DoWork));
            th1.Start();

            Thread th2 = new Thread(new ParameterizedThreadStart(DoWork2));
            th2.Start(int.MaxValue);


            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;
                if (j % 100000 == 0)
                {
                    Console.WriteLine("Main");
                }
            }


            Console.ReadLine();
        }

        static void DoWork()
        {
            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;
                if (j%100000==0)
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
