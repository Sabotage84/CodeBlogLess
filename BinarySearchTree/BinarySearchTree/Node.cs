using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Node<T>
        where T:IComparable
    {
        public T Data { get; private set; }

        public Node<T> Left { get; private set;}

        public Node<T> Right { get; private set; }

        public Node(T data)
        {
            Data= data;
        }

        

    }
}
