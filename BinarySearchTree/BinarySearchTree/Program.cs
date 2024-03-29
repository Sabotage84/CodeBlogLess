﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(8);
            tree.Add(7); 
            tree.Add(4);  
            tree.Add(2);
            tree.Add(3);
            tree.Add(1);
            tree.Add(6);
            tree.Add(9);

            List<int> test= tree.Preorder();

            List<int> test2 = tree.Postorder();

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }

            foreach (var item in test2)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
