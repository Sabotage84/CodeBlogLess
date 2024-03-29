﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList.Model
{
    public class DuplexItem<T>
    {
        public T Data { get; set; }
        public DuplexItem<T> Previous { get; set; }
        public DuplexItem<T> Next { get; set; }

        public DuplexItem(T data)
        {
            Data = data; 
        }

        public override string ToString()
        {
            return Data.ToString();
        }

        
    }
}
