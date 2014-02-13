using BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter22
{
    public class BellmanFord
    {
        /**/
        public bool FindShortestDistance(GraphAdjacence<char> input, GraphNode<char> s)
        {
            
            List<GraphEdge<GraphNode<char>>> edges = new List<GraphEdge<GraphNode<char>>>();
            foreach (GraphNode<char> n in input.Nodes)
            {
                foreach (KeyValuePair<GraphNode<char>, int> item in n.Neiborghs)
                {
                    edges.Add(new GraphEdge<GraphNode<char>>()
                    {
                        Left = n,
                        Right = item.Key,
                        Weight = item.Value
                    });
                }
                // use CC_Id as distance.
                n.CC_Id = int.MaxValue;
            }
            s.CC_Id = 0;

            foreach (GraphNode<char> n in input.Nodes)
            {
                foreach (GraphEdge<GraphNode<char>> edge in edges)
                {
                    if (edge.Right.CC_Id > edge.Left.CC_Id + edge.Weight)
                    {
                        edge.Right.CC_Id = edge.Left.CC_Id + edge.Weight;
                    }
                }
            }

            foreach (GraphEdge<GraphNode<char>> edge in edges)
            {
                if (edge.Right.CC_Id > edge.Left.CC_Id + edge.Weight)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
