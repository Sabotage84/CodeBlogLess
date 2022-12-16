using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDeque.Model
{
    internal class DuplexLinkedDeque<T>
    {
        public DuplexItem<T> Head;

        public DuplexItem<T> Tail; 

        public int Count { get; private set; }

        public DuplexLinkedDeque() { }

        public DuplexLinkedDeque(T data)
        {
            SetHeadItem(data);
        }

        private void SetHeadItem(T data)
        {
            var item = new DuplexItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void PushBack(T data)
        {
            if(Count==0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new DuplexItem<T>(data);
            item.Next = Tail;
            Tail.Previous = item;
            Tail = item;
            Count++;
            return;
        }

        public T PopBack()
        {
            if (Count > 0)
            {
                var res = Tail.Data;
                Tail=Tail.Next;
                Tail.Previous = null;
                Count--;
                return res;
            }
            return default(T);

        }

        public T PopFront()
        {
            if (Count > 0)
            {
                if(Count==1)
                {
                    var res1 = Head.Data;
                    Head = null;
                    Tail = Head;
                    return res1;
                }
                var res = Head.Data;
                Head = Head.Previous;
                Head.Next = null;
                Count--;
                return res;
            }
            return default(T);
        }

        public void PushFront(T data)
        {
            if(Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new DuplexItem<T>(data);
            Head.Next = item;
            item.Previous = Head;
            Head = item;
            Count++;
            return;

        }

        public T PeekBack()
        {
            return Tail.Data;
        }

        public T PeekFront()
        {
            return Head.Data;
        }

        public void Show()
        {
            string res = "";
            var item = Tail;
            while (item != null)
            {
                res += item.ToString() + " ";
                item = item.Next;
            }
            Console.WriteLine(res);

        }
    }
}
