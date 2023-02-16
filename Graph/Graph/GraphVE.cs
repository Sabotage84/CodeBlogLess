using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class GraphVE
    {
        List<Vertex> Vertexes = new List<Vertex>();
        List<Edge> Edges = new List<Edge>();

        public int[,] GetMatrix()
        {
            var matrix = new int[Vertexes.Count, Vertexes.Count];

            foreach (var item in Edges)
            {
                var row = item.From.Number;
                var col = item.To.Number;

                matrix[row, col] = item.Weight;

            }


            return matrix;
        }
    }
}
