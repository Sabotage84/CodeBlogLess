﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList.Model
{
    public class DuplexList<T>:IEnumerable<T>
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
            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
            }
            else
            {
                Tail.Next = item;
                item.Previous = Tail;
                Tail = item;
                Count++;
            }
        }

        public void Delete(T data)
        {
            var current = Head;

            if (current.Data.Equals(data))
            {
                Head = current.Next;
                Head.Previous = null;
                return;
            }
            current = current.Next;
            while (current!=null)
            {

                if (current.Data.Equals(data))
                {
                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                        current.Previous.Next = current.Next;
                        
                        Count--;
                        return;
                    }
                    else
                    {
                        current.Previous.Next = null;
                        Tail = current.Previous;
                        Count--;
                        return;
                    }
                }

                current = current.Next;
            }
        }

         IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();

        }

        public DuplexList<T> Reverse()
        {
            DuplexList<T> result = new DuplexList<T>();

            var current = Tail;

            while (current!=null)
            {
                result.Add(current.Data);
                current = current.Previous;
            }
                        return result;
        }

        public IEnumerator GetEnumerator()
        {
             var current = Head;
            while (current!=null)
            {
                yield return current;
                current = current.Next;
            }
        }

        public void Show()
        {
            var current = Head;
            while (current!=null)
            {
                Console.Write(current.Data.ToString() + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
