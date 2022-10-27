using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    public class LinkedList<T>
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }

        public int Count { get; private set; }
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;

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
    }
}
