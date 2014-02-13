using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    public class Graph<T>
    {
        public List<GraphEdge<T>> Edges;
    }

    public class GraphEdge<T>
    {
        public T Left;
        public T Right;
        public int Weight;
    }
}
