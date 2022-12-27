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
        


    }
}
