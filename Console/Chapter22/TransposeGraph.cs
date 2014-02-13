using BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter22
{
    public class TransposeGraph
    {
        /// <summary>
        /// this should be able to be done at O(V+E)
        /// </summary>
        /// <param name="graph"></param>
        public void CreateTranspose(GraphAdjacence<int> graph)
        {
            if (graph == null) return;
            foreach (GraphNode<int> node in graph.Nodes)
            {
                foreach (KeyValuePair<GraphNode<int>, int> neiborgh in node.Neiborghs)
                {
                    foreach (GraphNode<int> n in graph.Nodes) // should be able to find a node in O(1). 
                    {
                        if (n == neiborgh.Key)
                        {
                            if (n.TransposeNeiborghs == null)
                            {
                                n.TransposeNeiborghs = new List<KeyValuePair<GraphNode<int>, int>>();
                            }
                            n.TransposeNeiborghs.Add(new KeyValuePair<GraphNode<int>, int>(node, neiborgh.Value));
                        }
                    }
                }
            }
        }
    }
}
