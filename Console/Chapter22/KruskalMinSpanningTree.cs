using BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter22
{
    public class KruskalMinSpanningTree
    {
        public List<GraphEdge<GraphNode<char>>> FindMinSpanningTree(GraphAdjacence<char> graph)
        {
            if (graph == null) return null;

            List<GraphEdge<GraphNode<char>>> edges = new List<GraphEdge<GraphNode<char>>>();

            foreach (GraphNode<char> n in graph.Nodes)
            {
                foreach (KeyValuePair<GraphNode<char>, int> pair in n.Neiborghs)
                {
                    edges.Add(new GraphEdge<GraphNode<char>>()
                    {
                        Left = n,
                        Right = pair.Key,
                        Weight = pair.Value
                    });
                }
            }

            edges = edges.OrderBy(x => x.Weight).ToList();
            List<GraphEdge<GraphNode<char>>> res = new List<GraphEdge<GraphNode<char>>>();

            foreach (GraphEdge<GraphNode<char>> edge in edges)
            {
                if (FindSet(edge.Left) != FindSet(edge.Right))
                {
                    FindSet(edge.Left).Pie = FindSet(edge.Right);
                    res.Add(edge);
                }
            }

            return res;
        }

        private GraphNode<char> FindSet(GraphNode<char> node)
        {
            if (node.Pie == null)
            {
                return node;
            }
            else
            {
                return FindSet(node.Pie);
            }
        }
    }
}
