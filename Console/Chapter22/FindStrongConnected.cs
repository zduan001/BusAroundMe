using BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter22
{
    public class FindStrongConnected
    {
        public void FindSCC(GraphAdjacence<int> input)
        {
            if(input == null || input.Nodes.Count ==0 ) return;

            // create transpose
            TransposeGraph transpose = new TransposeGraph();
            transpose.CreateTranspose(input);

            // first round DFE
            DFS dfs = new DFS();
            dfs.DFSSearch(input);

            //sort nodes on finish time
            input.Nodes = input.Nodes.OrderByDescending (x => x.FinishTime).ToList();
            foreach (GraphNode<int> node in input.Nodes)
            {
                List<KeyValuePair<GraphNode<int>, int>> tmp = node.Neiborghs;
                node.Neiborghs = node.TransposeNeiborghs;
                node.TransposeNeiborghs = tmp;
            }

            // DFS second round count the SCC
            dfs.DFSSearch(input);
        }
    }
}
