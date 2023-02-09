using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeapCB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var heap = new BinaryHeap();
            var rnd = new Random();
            var items = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                items.Add(rnd.Next(100,200));
            }

            heap=new BinaryHeap(items);

            for (int i = 0; i < 50; i++)
            {
                heap.Add(rnd.Next(100,200));
            }

            //Console.WriteLine(heap.Check());

            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}
