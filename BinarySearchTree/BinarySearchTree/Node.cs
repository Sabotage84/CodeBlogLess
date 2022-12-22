﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Node<T>
        where T:IComparable
    {
        public T Data { get; set; }
    }
}
