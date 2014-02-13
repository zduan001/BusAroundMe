using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    public class GraphAdjacence<T>
    {

        public GraphAdjacence()
        {

        }

        // Constructor Clone a graph
        public GraphAdjacence(GraphAdjacence<T> input)
        {
            if (input == null) return;
            if (input.Nodes == null) return;
            if (input.Nodes.Count == 0)
            {
                this.Nodes = new List<GraphNode<T>>();
                return;
            }

            Dictionary<GraphNode<T>, GraphNode<T>> map = new Dictionary<GraphNode<T>, GraphNode<T>>();
            foreach(GraphNode<T> oldNode in input.Nodes)
            {
                GraphNode<T> newNode = new GraphNode<T>()
                {
                    DiscoverTime = oldNode.DiscoverTime,
                    FinishTime = oldNode.FinishTime,
                    Key = oldNode.Key,
                    State = oldNode.State,
                    Pie = oldNode.Pie
                };
                map.Add(oldNode, newNode);
            }

            foreach (GraphNode<T> oldNode in input.Nodes)
            {
                if (oldNode.Neiborghs != null)
                {
                    map[oldNode].Neiborghs = new List<KeyValuePair<GraphNode<T>, int>>();
                    foreach (KeyValuePair<GraphNode<T>, int> node in oldNode.Neiborghs)
                    {
                        map[oldNode].Neiborghs.Add(new KeyValuePair<GraphNode<T>, int>(map[node.Key], node.Value));
                    }
                }
            }

            this.Nodes = new List<GraphNode<T>>();
            foreach (GraphNode<T> node in input.Nodes)
            {
                this.Nodes.Add(map[node]);
            }

        }
        public List<GraphNode<T>> Nodes;
    }
}
