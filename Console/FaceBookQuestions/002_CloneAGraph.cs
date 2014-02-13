using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookQuestions
{
    public class _002_CloneAGraph
    {
        /*
         * Difficulty: ***
         * Given a graph clone it. this is my FB phone interview but I forgot to check the null input.
         * public class Node
            {
             public int Data;
             public List<Node> neighbors;
            }
            public class Graph
            {
            public List<Node> Nodes;
            }
         * this is the graphy defination. I also forgot that there might be some node does not have neighbors.
         * I do not think I passed phone screen. but if the interviewer mean "Nodes" in the Graph class contains 
         * all the nodes in the graph, I might be OK. let's see see ba.
         * 
         * Here I assume the Nodes in Graph class contains all the nodes.
         */
        public class Graph
        {
            public List<GraphNode> Nodes;
        }


        public Graph CloneGraph(Graph input)
        {
            if (input == null)
            {
                return null;
            }
            Dictionary<GraphNode, GraphNode> dict = new Dictionary<GraphNode, GraphNode>();
            foreach (GraphNode node in input.Nodes)
            {
                if (!dict.Keys.Contains(node))
                {
                    dict.Add(node, new GraphNode(node.Value));
                }
            }

            foreach (GraphNode node in input.Nodes)
            {
                foreach (GraphNode neighbor in node.Neighbors)
                {
                    dict[node].Neighbors.Add(dict[neighbor]);
                }
            }

            Graph res = new Graph();
            foreach (GraphNode node in input.Nodes)
            {
                res.Nodes.Add(dict[node]);
            }

            return res;
        }
        
    }
}
