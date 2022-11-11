using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList.Model
{
    public class DuplexList<T>
    {
        public DuplexItem<T> Head {get; set;}

        public DuplexItem<T> Tail { get; set; }

        public int Count { get; set; }

        public DuplexList()
        {

        }

        public DuplexList(T data)
        {
            var item = new DuplexItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Add(T data)
        {
            var item = new DuplexItem<T>(data);
            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }

        public void Delete(T data)
        {
            var current = Head;

            while (current!=null)
            {

                if (current.Data.Equals(data))
                {
                    current.Next.Previous = current.Previous;
                    current.Previous.Next = current.Next;
                    Count--;
                    return;
                }

                current = current.Next;
            }
        }

    }
}
