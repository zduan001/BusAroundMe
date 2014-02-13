using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    public class GraphNode<T>
    {
        public VisitState State;
        public T Key;
        public GraphNode<T> Pie;
        public List<KeyValuePair<GraphNode<T>, int>> Neiborghs;
        public List<KeyValuePair<GraphNode<T>, int>> TransposeNeiborghs;
        public int DiscoverTime;
        public int FinishTime;
        public int CC_Id;
    }


    public enum VisitState
    {
        NotVisted,
        Visiting,
        Visited
    }
}
