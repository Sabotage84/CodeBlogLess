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
            heap.Add(20);
            heap.Add(11);
            heap.Add(17);
            heap.Add(7);
            heap.Add(4);
            heap.Add(13);
            heap.Add(15);
            heap.Add(14);

            while (heap.Count>0)
            {
                Console.WriteLine(heap.GetMax());

            }
          
            Console.ReadLine();
        }
    }
}
