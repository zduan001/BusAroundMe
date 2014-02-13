using BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter22
{
    public class Dijkstra
    {

        public Dictionary<GraphNode<char>,int> FindShortestPart(GraphAdjacence<char> graph, GraphNode<char> start)
        {
            if (start == null || graph == null) return null;

            HashSet<GraphNode<char>> res = new HashSet<GraphNode<char>>();
            Dictionary<GraphNode<char>, int> distance = new Dictionary<GraphNode<char>, int>();
            foreach (GraphNode<char> node in graph.Nodes)
            {
                if (node == start)
                {
                    distance.Add(node, 0);
                }
                else
                {
                    distance.Add(node, int.MaxValue);
                }
            }

            res.Add(start);

            while (res.Count != graph.Nodes.Count)
            {
                foreach (GraphNode<char> n in res)
                {
                    foreach (KeyValuePair<GraphNode<char>, int> neighbor in n.Neiborghs)
                    {
                        if (!res.Contains(neighbor.Key) && distance[neighbor.Key] > distance[n] + neighbor.Value)
                        {
                            distance[neighbor.Key] = distance[n] + neighbor.Value;
                        }
                    }
                }

#region should be able to use heap. call descrease key here.
                GraphNode<char> tmp = null;
                int min = int.MaxValue;
                foreach (GraphNode<char> n in graph.Nodes)
                {
                    if (!res.Contains(n) && distance[n] < min)
                    {
                        tmp = n;
                        min = distance[n];
                    }
                }
                if (tmp != null)
                {
                    res.Add(tmp);
                }
#endregion
            }
            return distance;
        }
    }
}
