using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeapCB
{
    internal class BinaryHeap
    {
        private List<int> items= new List<int>();
        public int Count { get { return items.Count; } }

        public int GetMax()
        {
            if (Count > 0) 
            { 
            return items[0];
        
            }
            else
            {
                return default(int);
            }
        }

        public void Add(int item)
        {
            items.Add(item);

            var currentIndex = Count-1;
            var parentIndex = (currentIndex - 1) / 2;

            while (currentIndex>0 && items[parentIndex] < items[currentIndex])
            {
                var temp = items[currentIndex];
                items[currentIndex] = items[parentIndex];
                items[parentIndex] = temp;

                currentIndex = parentIndex;
                parentIndex = (currentIndex - 1) / 2;
            }

        }
    }
}
