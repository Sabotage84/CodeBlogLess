﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeapCB
{
    internal class BinaryHeap : IEnumerable
    {
        private List<int> items= new List<int>();
        public int Count { get { return items.Count; } }

        public int? Peek()
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
        public BinaryHeap()
        {

        }

        public BinaryHeap(List<int> items)
        {
            this.items.AddRange(items);
            for (int i = Count; i >=0; i--)
            {
                Sort(i);
            }
            
        }

        public void Add (int item)
        {
            items.Add(item);

            var currentIndex = Count - 1;
            var parentIndex = GetParentIndex(currentIndex);

            while (currentIndex > 0 && items[parentIndex] < items[currentIndex])
            {
                Swap(currentIndex, parentIndex);

                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }

        }

        public int GetMax()
        {
            var result = items[0];

            items[0] = items[Count - 1];
            items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }

        private void Sort(int currentIndex)
        {
            
            int leftIndex;
            int rightIndex;
            int maxIndex= currentIndex;
            while (currentIndex<Count)
            {
                
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if (leftIndex<Count && items[leftIndex] > items[maxIndex])
                {
                    maxIndex= leftIndex;
                }
                if (rightIndex<Count && items[rightIndex] > items[maxIndex])
                {
                    maxIndex = rightIndex;
                }

                if(maxIndex==currentIndex)
                {
                    break;
                }

                Swap(currentIndex, maxIndex);
                currentIndex= maxIndex;
            }


        }

        private void Swap(int currentIndex, int parentIndex)
        {
            var temp = items[currentIndex];
            items[currentIndex] = items[parentIndex];
            items[parentIndex] = temp;
        }

        private static int GetParentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        public IEnumerator GetEnumerator()
        {
            while (Count>0)
            {
                yield return GetMax();
            }
        }

        public bool Check()
        {
            var res = true;
            var max = Peek();
            foreach (var item in this)
            {
                var cur = GetMax();
                if (max < cur)
                    return false;
                max= cur;
            }
            return res;
        }
    }
}
