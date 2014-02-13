using BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter22
{
    public class DFS
    {
        private int time;
        /*
         * DFS of a graphy
         */
        public void DFSSearch(GraphAdjacence<int> g)
        {
            if (g == null || g.Nodes == null || g.Nodes.Count == 0) return;
            List<GraphNode<int>> input = g.Nodes;

            foreach (GraphNode<int> node in input)
            {
                node.State = VisitState.NotVisted;
            }
            time = 0;
            int cc_Id = 0;
            foreach (GraphNode<int> node in input)
            {
                if (node.State == VisitState.NotVisted)
                {
                    DFS_Visit(node, cc_Id);
                    cc_Id++;
                }
            }
        }

        private void DFS_Visit(GraphNode<int> node, int cc_Id)
        {
            time++;
            node.DiscoverTime = time;
            node.State = VisitState.Visiting;
            node.CC_Id = cc_Id;
            if (node.Neiborghs != null)
            {
                foreach (KeyValuePair<GraphNode<int>, int> tmp in node.Neiborghs)
                {
                    if (tmp.Key.State == VisitState.NotVisted)
                    {
                        DFS_Visit(tmp.Key, cc_Id);
                        tmp.Key.Pie = node;
                    }
                }
            }
            time++;
            node.FinishTime = time;
            node.State = VisitState.Visited;
        }
    }
}
