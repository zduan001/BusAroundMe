using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter4_TreeGraph
{
    public class _04_02_DriectGraph
    {
        /*
         * Given a directed graph, design an algorithm to find out whether there is a route between two nodes.
         */
        public bool FindIf2NodesConnected(Dictionary<int, List<int>> graph, int start, int end)
        {
            HashSet<int> visited = new HashSet<int>();
            bool res = IsConnected(graph, start, end, visited);
            return res;
        }

        public bool IsConnected(Dictionary<int, List<int>> graph, int i, int j, HashSet<int> visited)
        {
            bool found = false;
            List<int> nodes = null;
            if (graph.Keys.Contains(i))
            {
                nodes = graph[i];
            }
            if (nodes != null)
            {

                foreach (int k in nodes)
                {
                    if (!visited.Contains(k))
                    {
                        visited.Add(k);
                        if (k == j)
                        {
                            return true;
                        }
                        else
                        {
                            if (IsConnected(graph, k, j, visited))
                            {
                                return true;
                            }
                        }
                        visited.Remove(k);
                    }
                }
            }
            return found;
        }
    }
}
