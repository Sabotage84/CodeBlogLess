using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList.Model
{
    public class CircularLinkedList<T>
    {
        public DuplexItem<T> Head { get; set; }
        public int Count { get; set; }

        public CircularLinkedList()
        {

        }

        public CircularLinkedList(T data)
        {
            Head = new DuplexItem<T>(data);
            Head.Next = Head;
            Head.Previous = Head;
            Count = 1;
        }

        public void Add(T data)
        {
            var newItem = new DuplexItem<T>(data);
            if (Count==0)
            {
                Head = new DuplexItem<T>(data);
                Head.Next = Head;
                Head.Previous = Head;
                Count = 1;
            }
            else 
            { 
                Head.Previous.Next = newItem;
                newItem.Previous = Head.Previous;
                newItem.Next = Head;
                Head.Previous = newItem;
                Count++;
            }
        }

        public void Delete(T data)
        {
            var item = new DuplexItem<T>(data);
            var current = Head;
            if (current.Data.Equals(item.Data))
            {
                Head = current.Next;
                current.Next.Previous = current.Previous;
                current.Previous.Next = current.Next;
                Count--;
                return;
            }
            current = current.Next;
            while (!current.Equals(Head))
            {
                if (current.Data.Equals(item.Data))
                {
                    current.Next.Previous = current.Previous;
                    current.Previous.Next = current.Next;
                    Count--;
                    return;
                }
                current = current.Next;
            }
           
        }

        public void Show()
        {
            var current = Head;
            do
            {
                Console.Write(current.Data+ " ");
                current = current.Next;
            } while (!current.Equals(Head));
            Console.WriteLine();
        }

    }
}
