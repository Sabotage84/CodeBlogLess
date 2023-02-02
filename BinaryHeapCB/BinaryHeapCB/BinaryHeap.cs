using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeapCB
{
    internal class BinaryHeap<T>
    {
        private List<T> items= new List<T>();
        public int Count { get { return items.Count; } }

        public T GetMax()
        {
            return items[0];
        }
    }
}
