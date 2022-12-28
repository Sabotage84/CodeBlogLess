using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Tree<T> where T : IComparable
    {
        public Node<T> Root { get; private set; }

        public int Count { get; private set; }
        public Tree(T data) { }
    }
}
