﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    public class LinkedList<T>:IEnumerable<T>
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }

        public int Count { get; private set; }
        public LinkedList()
        {
            Clear();
        }
        public LinkedList(T data)
        {
            var item = new Item<T>(data);
            SetHeadAndTAil(item);
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);

            if (Tail!=null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTAil(item);
            }
        }

        public void Delete(T data)
        {
            if (Head != null)
            {
                if(Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head;


                while (current!=null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            
        }

        public void InsertAfter(T target, T data)
        {
            var item = new Item<T>(data);
            if (Head != null)
            {
                if (Head.Data.Equals(target))
                {
                    item.Next = Head.Next.Next;
                    Head.Next = item;
                    return;
                }
                var current = Head.Next;
                


                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        item.Next = current.Next.Next;
                        current.Next=item;
                        return;
                    }
                    
                    current = current.Next;
                }
            }
            
        }


        private void SetHeadAndTAil(Item<T> item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Show()
        {
            string res = "";
            var current = Head;
            while (current!=null)
            {
                res += current.Data.ToString()+" ";
                current = current.Next;
            }
            Console.WriteLine(res);
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void AppendHead(T data)
        {
            var item = new Item<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            Console.WriteLine(typeof(T));
            while (current!=null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return "Linked List " + Count + " elements!";
        }

    }
}
