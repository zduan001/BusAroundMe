using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookQuestions
{
    public class _003_CloneASingleStartedGraph
    {
        /* difficulty: ***
         * this question will be the follow up of the 002. what if the only one graphy node passed in
         * actually this is copy a special tree, in which child can point to an ancestor.
         */
        public GraphNode CloneAGraphNode(GraphNode input)
        {
            Dictionary<GraphNode, GraphNode> dict = new Dictionary<GraphNode, GraphNode>();
            Queue<GraphNode> q = new Queue<GraphNode>();
            q.Enqueue(input);
            dict.Add(input, new GraphNode(input.Value));
            while (q.Count != 0)
            {
                GraphNode tmp = q.Dequeue();
                
                foreach (GraphNode node in tmp.Neighbors)
                {
                    q.Enqueue(node);
                    if (!dict.Keys.Contains(node))
                    {
                        dict.Add(node, new GraphNode(node.Value));
                    }
                    dict[tmp].Neighbors.Add(dict[node]);
                }
            }
            return dict[input];
        }

        // nothing fancy just use a recursive DFS.
        public GraphNode CloneAGraphNodeDFS(GraphNode input, Dictionary<GraphNode, GraphNode> map)
        {
            if (map.Keys.Contains(input))
            {
                return null;
            }

            map.Add(input, new GraphNode(input.Value));
            foreach (GraphNode n in input.Neighbors)
            {
                if (map.Keys.Contains(n))
                {
                    map[input].Neighbors.Add(map[n]);
                }
                else
                {
                    map[input].Neighbors.Add(CloneAGraphNodeDFS(n, map));
                }
            }
            return map[input];
        }
    }
}
