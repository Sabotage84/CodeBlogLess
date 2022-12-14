using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDeque.Model
{
    internal class EseayQueue<T>
    {
        private List<T> items = new List<T>();

        private T Head  => items.Last();

        private T Tail => items.First();

        public int Count => items.Count;

        public EseayQueue()
        {

        }
        public EseayQueue(T data)
        {
            items.Add(data);
        }

        public void Enqueue(T data)
        {
            items.Insert(0, data);
        }

        public T Dequeue()
        {
            T res = Head;
            items.Remove(Head);
            return res;
        }

        public T Peek()
        {
            return Head;
        }

    }
}
