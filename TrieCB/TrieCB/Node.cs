using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieCB
{
    internal class Node<T>
    {
        public string Key { get; set; }

        public T Data { get; set; }

        public bool IsWord { get; set; }
        
        public Dictionary<string, Node<T>> SubNodes { get; set; }

        public Node(T data)
        {
            Data= data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

        public override bool Equals(object obj) 
        {
            if (obj is Node<T> item) 
            {
                return Data.Equals(item.Data);
            }
            else
            {
                return false;
            }
        }

    }
}
