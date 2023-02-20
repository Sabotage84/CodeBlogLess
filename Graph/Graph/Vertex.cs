using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Vertex
    {
        public int Number { get; set; }

        public bool Visited { get; set; }
        public Vertex(int number)
        {
            Number = number;
        }

        public bool Oriented { get; set; }

        public override string ToString()
        {
            return Number.ToString();
        }

    }
}
