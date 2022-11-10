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

    }
}
