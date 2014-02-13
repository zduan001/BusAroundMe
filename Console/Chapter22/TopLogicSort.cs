using BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter22
{
    public class TopLogicSort
    {
        private int time = 0;
        public LinkListNode<GraphNode<int>> Sort(GraphAdjacence<int> dag)
        {
            LinkListNode<GraphNode<int>> res = new BaseClass.LinkListNode<GraphNode<int>>();
            for (int i = 0; i < dag.Nodes.Count; i++)
            {
                dag.Nodes[i].State = VisitState.NotVisted;
            }
            foreach (GraphNode<int> node in dag.Nodes)
            {
                if (node.State == VisitState.NotVisted)
                {
                    DFS_Visit(node, ref res);
                }
            }
            return res;
        }


        private void DFS_Visit(GraphNode<int> input, ref LinkListNode<GraphNode<int>> res)
        {
            time++;
            input.DiscoverTime = time;
            foreach (KeyValuePair<GraphNode<int>, int> node in input.Neiborghs)
            {
                if (node.Key.State == VisitState.NotVisted)
                {
                    node.Key.State = VisitState.Visiting;
                    node.Key.Pie = input;
                    DFS_Visit(node.Key, ref res);
                }
            }
            time++;
            input.FinishTime = time;
            LinkListNode<GraphNode<int>> headNode = new LinkListNode<GraphNode<int>>()
            {
                Value = input,
                Next = res
            };
            res = headNode;
        }
    }
}
