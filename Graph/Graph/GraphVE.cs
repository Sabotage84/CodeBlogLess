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
                var row = item.From.Number-1;
                var col = item.To.Number-1;

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

        public List<Vertex> GetVertexLists(Vertex vertex)
        {
            var result = new List<Vertex>();

            foreach (var item in Edges)
            {
                if (item.From == vertex)
                    result.Add(item.To);
            }

            return result;
        }

        public void ShowVertexLists()
        {
            foreach (var v in Vertexes)
            {
                var lst = GetVertexLists(v);
                Console.Write($"Vertex {v.Number} has connection to: ");
                foreach (var item in lst)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        public bool Wave(Vertex start, Vertex finish)
        {
            //var result = new List<Vertex>();
            var list = new List<Vertex>
            {
                start
            };
            for (int i = 0; i < list.Count; i++)
            {
                var vertex = list[i];
                foreach (var item in GetVertexLists(vertex))
                {
                    if (!list.Contains(item))
                    {
                        item.Visited = true;
                        list.Add(item);
                    }
                }
            
            }

            return list.Contains(finish);
        }

    }
}
