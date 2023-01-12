using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieCB
{
    internal class Trie<T>
    {
        private Node<T> root;

        public int Count { get; set; }

        public Trie(T data)
        {
            root= new Node<T>("", data);
            Count=1;
        }

        public void Add (string key, T data)
        {

        }

        public void Remove (string key) 
        {
            
        }


        public T Search(string key)
        {

        }
    }
}
