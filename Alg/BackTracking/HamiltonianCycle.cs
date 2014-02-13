using BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking
{
    public class HamiltonianCycle
    {
        /*http://www.geeksforgeeks.org/backtracking-set-7-hamiltonian-cycle/
         * Hamiltonian Path in an undirected graph is a path that visits each vertex exactly once. 
         * A Hamiltonian cycle (or Hamiltonian circuit) is a Hamiltonian Path such that there is an 
         * edge (in graph) from the last vertex to the first vertex of the Hamiltonian Path. Determine 
         * whether a given graph contains Hamiltonian Cycle or not. If it contains, then print the path. 
         * Following are the input and output of the required function.
         */
        public bool FindHamiltonCycle<T>(GraphAdjacence<T> input)
        {
            if (input == null || input.Nodes == null || input.Nodes.Count == 0) return false;

            HashSet<T> tracker = new HashSet<T>();
            // Here I set the start point. if start point can be random I can 
            // have a loop here start at each vertex.
            tracker.Add(input.Nodes[0].Key);
            return Runner(input, tracker, input.Nodes[0]);
        }

        private bool Runner<T>(GraphAdjacence<T> graph, HashSet<T> tracker, GraphNode<T> root)
        {
            
            if (graph.Nodes.Count == tracker.Count)
            {
                return true;
            }

            foreach (KeyValuePair<GraphNode<T>, int> pair in root.Neiborghs)
            {
                if (!tracker.Contains(pair.Key.Key))
                {
                    tracker.Add(pair.Key.Key);
                    if (Runner(graph, tracker, pair.Key))
                    {
                        return true;
                    }
                    else
                    {
                        tracker.Remove(pair.Key.Key);
                    }
                }
            }
            
            return false;
        }
    }
}
