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

        public override string ToString()
        {
            return Number.ToString();
        }

    }
}
