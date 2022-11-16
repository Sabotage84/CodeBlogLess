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
            Count = 1;
        }

    }
}
