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
        public Tree() { }

        public void Add(T data)
        { 
            if (Root==null)
            {
                Root=  new Node<T>(data);
                Count=1;
                return;
            }
            Root.Add(data);
            Count++;
        }

        public List<T> Preorder() 
        {
            var res = new List<T>();

            var current = Root;

            if (current!=null)
            {
                res.Add(current.Data);
                if(current.Left!=null) 
                {
                    res.AddRange(Preorder(current.Left));
                }
                if (current.Right!=null)
                {
                    res.AddRange(Preorder(current.Right));
                }
            }
            return res;
        }

        public List<T> Inorder()
        {
            var res = new List<T>();

            var current = Root;

            if (current != null)
            {
                
                if (current.Left != null)
                {
                    res.AddRange(Preorder(current.Left));
                }

                res.Add(current.Data);

                if (current.Right != null)
                {
                    res.AddRange(Preorder(current.Right));
                }
            }
            return res;
        }
        public List<T> Postorder()
        {
            var res = new List<T>();

            var current = Root;

            if (current != null)
            {
                
                if (current.Left != null)
                {
                    res.AddRange(Postorder(current.Left));
                }
                if (current.Right != null)
                {
                    res.AddRange(Postorder(current.Right));
                }
                res.Add(current.Data);
            }
            return res;
        }

        private List<T> Preorder(Node<T> node)
        {
            var res = new List<T>();
            if (node!=null)
            {
                res.Add(node.Data);

                if (node.Left!=null)
                {
                    res.AddRange(Preorder(node.Left));

                }
                if(node.Right!=null)
                {
                    res.AddRange(Preorder(node.Right));
                }
            }
            return res;
        }

        private List<T> Postorder(Node<T> node)
        {
            var res = new List<T>();
            if (node != null)
            {
               

                if (node.Left != null)
                {
                    res.AddRange(Postorder(node.Left));

                }
                if (node.Right != null)
                {
                    res.AddRange(Postorder(node.Right));
                }

                res.Add(node.Data);
            }
            return res;
        }

        private List<T> Inorder(Node<T> node)
        {
            var res = new List<T>();
            if (node != null)
            {


                if (node.Left != null)
                {
                    res.AddRange(Inorder(node.Left));

                }

                res.Add(node.Data);

                if (node.Right != null)
                {
                    res.AddRange(Inorder(node.Right));
                }

               
            }
            return res;
        }
    }
}
