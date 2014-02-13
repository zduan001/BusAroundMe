using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.G_Code
{
    public class G_020_CloneGraph
    {
        /*
         * 复制无loop的有向图
         */
        public GraphNode CloneGraph(GraphNode input)
        {
            Dictionary<GraphNode, GraphNode> map = new Dictionary<GraphNode, GraphNode>();
            Queue<GraphNode> q = new Queue<GraphNode>();
            q.Enqueue(input);

            while (q.Count > 0)
            {
                GraphNode tmp = q.Dequeue();
                if (!map.Keys.Contains(tmp))
                {
                    GraphNode cloneNode = new GraphNode(tmp.Value);
                    map.Add(tmp, cloneNode);
                    foreach (GraphNode node in tmp.Neighbors)
                    {
                        q.Enqueue(node);
                    }
                }
            }

            foreach (GraphNode node in map.Keys)
            {
                foreach (GraphNode child in node.Neighbors)
                {
                    map[node].Neighbors.Add(map[child]);
                }
            }

            return map[input];
        }

        /// <summary>
        /// what is the different between this method and the first method?
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public GraphNode CloneGaphII(GraphNode input)
        {
            Dictionary<GraphNode, GraphNode> map = new Dictionary<GraphNode, GraphNode>();
            Queue<GraphNode> q = new Queue<GraphNode>();
            q.Enqueue(input);
            map.Add(input, new GraphNode(input.Value));

            while (q.Count > 0)
            {
                GraphNode currentNode = q.Dequeue();
                foreach (GraphNode neighbor in currentNode.Neighbors)
                {
                    if (!map.Keys.Contains(neighbor))
                    {
                        GraphNode tmp = new GraphNode(neighbor.Value);
                        map.Add(neighbor, tmp);
                        map[currentNode].Neighbors.Add(tmp);
                    }
                    q.Enqueue(neighbor);
                }
            }
            return map[input];
        }
    }
}
