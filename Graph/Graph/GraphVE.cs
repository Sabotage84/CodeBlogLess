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

        public void AddVertex(Vertex v)
        {

            Vertexes.Add(v);
        }

        public void Remove(Vertex v) { }

        public void AddEdge(Vertex from, Vertex to)
        {
            Edges.Add(new Edge(from,to));
        }


        public int[,] GetMatrix()
        {
            var matrix = new int[Vertexes.Count, Vertexes.Count];

            foreach (var item in Edges)
            {
                var row = item.From.Number;
                var col = item.To.Number;

                matrix[row, col] = item.Weight;
                matrix[col, row] = item.Weight;
            }


            return matrix;
        }

        public void ShowMatrix()
        {
            var matrix = GetMatrix();
            for (int i = 0; i < Vertexes.Count; i++)
            {
                if (i == 0)
                {
                    for (int l = 0; l < Vertexes.Count; l++)
                    {
                        if (l == 0)
                        {
                            Console.Write("  ");
                        }
                        Console.Write((l + 1) + " ");
                    }
                    Console.WriteLine();
                }
                for (int j = 0; j < Vertexes.Count; j++)
                {
                    if (j == 0)
                    {
                        Console.Write((i+1)+" ");
                    }
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
