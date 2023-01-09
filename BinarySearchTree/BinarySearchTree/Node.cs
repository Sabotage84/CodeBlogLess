using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Node<T> : IComparable
        where T:IComparable
    {
        public T Data { get; private set; }

        public Node<T> Left { get; private set;}

        public Node<T> Right { get; private set; }

        public Node(T data)
        {
            Data= data;
        }

        public Node(T data, Node<T> left, Node<T> right)
        {
        
            Data= data;
            Left= left;
            Right= right;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return -1;
            if (obj is Node<T>)
            {
                return Data.CompareTo(obj);
            }
            else
            {
                throw new ArgumentException("Не соответствие типов!");

            }

        }

        public int CompareTo(T other)
        {
            return Data.CompareTo(other);
        }
    }
}
