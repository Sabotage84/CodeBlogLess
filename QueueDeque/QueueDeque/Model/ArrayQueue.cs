using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDeque.Model
{
    internal class ArrayQueue<T>
    {

        private T[] items;

        private T Head => items[Count>0? Count-1:0];

        private T Tail => items[0];

        private int MaxCount => items.Length;

        public int Count { get;private set; }

        public ArrayQueue(int size)
        {
            items= new T[size];
            Count = 0;
        }
        public ArrayQueue(int size, T data)
        {

            items = new T[size];
            items[0] = data;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            if (Count < MaxCount)
            {
                var res = new T[MaxCount];
                res[0] = data;

                for (int i = 1; i < Count; i++)
                {
                    res[i] = items[i - 1];
                }

                items=res;
                Count ++;

            }
        }

        public T Dequeue(T data)
        {
            T res = Head;
            Count--;
            return res;
        }

        public T Peek()
        {
            return Head;
        }

    }
}
