using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Edge
    {
        public Vertex To { get; set; }
        public Vertex From { get; set; }
        
        public bool Oriented { get; set; }
        public int Weight { get; set; }



    }
}
