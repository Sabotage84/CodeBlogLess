using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDeque.Model
{
    internal class EasyDeue<T>
    {
        private List<T> items = new List<T>();

        public T Head => items.Last();

        public T Tail => items.First();

        int Count => items.Count();

        public EasyDeue() { }

        public EasyDeue(T data)
        {
            items.Add(data);
        }
        public void PushBack(T data)
        {
            items.Insert(0, data);
        }

        public T PopBack()
        {
            var res=Tail;
            items.Remove(Tail);
            return res;

        }

        public T PopFront()
        {
            var res = Head;
            items.Remove(Head);

            return res;
        }

        public void PushFront(T data)
        {
            items.Add(data);
        }

        public T PeekBack()
        {
            return Tail;
        }

        public T PeekFront()
        {
            return Head;
        }


    }

}
