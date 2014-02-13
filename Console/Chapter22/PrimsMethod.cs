using BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter22
{
    public class PrimsMethod
    {
        public Dictionary<GraphNode<char>, GraphNode<char>> Prims(GraphAdjacence<char> graph)
        {
            if (graph == null || graph.Nodes == null || graph.Nodes.Count == 0) return null;

            Dictionary<GraphNode<char>, int> res = new Dictionary<GraphNode<char>, int>();
            Dictionary<GraphNode<char>, GraphNode<char>> prev = new Dictionary<GraphNode<char>, GraphNode<char>>();
            HashSet<GraphNode<char>> container = new HashSet<GraphNode<char>>();

            foreach (GraphNode<char> n in graph.Nodes)
            {
                res.Add(n, int.MaxValue);
                prev.Add(n, null);
            }

            res[graph.Nodes[0]] = 0;
            //container.Add(graph.Nodes[0]);
            while (container.Count != graph.Nodes.Count)
            {
                // pick the smallest node in res not in container. 
                // should use min heap here.
                GraphNode<char> tmp = null;
                int min = int.MaxValue;
                foreach(GraphNode<char> n in graph.Nodes)
                {
                    if(!container.Contains(n))
                    {
                        if(res[n] < min)
                        {
                            tmp = n;
                            min = res[n];
                        }
                    }
                }

                // if no node has a smaller weight than int.maxvalue. that mean some nodes are total disconnected 
                // from rest of graph. so throw exception. min spaning treee is not feasible.
                if (tmp == null) throw new Exception();

                // update all nodes which from node tmp.
                foreach (KeyValuePair<GraphNode<char>, int> kvp in tmp.Neiborghs)
                {
                    if (!container.Contains(kvp.Key) && kvp.Value < res[kvp.Key])
                    {
                        res[kvp.Key] = kvp.Value;
                        prev[kvp.Key] = tmp;
                    }
                }

                container.Add(tmp);
            }

            return prev;
        }
    }
}
