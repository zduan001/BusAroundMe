using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _016_FindAllPath
    {
        /*
         * this is a question come up while I was talking to Andy about algorithm
         * find all possilbe path between 2 nodes in a graph.
         */
        public List<List<int>> FindAllPath(List<GraphNode> graph, GraphNode start, GraphNode end)
        {
            Stack<GraphNode> s = new Stack<GraphNode>();
            List<List<int>> res = new List<List<int>>();
            s.Push(start); start.Visited = true;
            while (s.Count != 0)
            {
                GraphNode tmp = s.Pop();
                foreach(GraphNode node in tmp.Neighbors)
                {
                    if (node == end)
                    {
                        List<int> list = new List<int>();
                        list.Insert(0, node.Value);
                        GraphNode n = tmp;
                        while(n!= null)
                        {
                            list.Insert(0, n.Value);
                            n = n.Previous;
                        }
                        res.Add(list);
                        break;
                    }
                    else
                    {
                        node.Previous = tmp;
                        node.Visited = true;
                        s.Push(node);
                    }
                }
                //tmp.Previous = null;
                tmp.Visited = false;
            }

            return res;
        }
    }
}
