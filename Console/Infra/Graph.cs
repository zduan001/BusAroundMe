using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra
{
    public class GraphNode
    {
        public GraphNode(int value)
        {
            Value = value;
            Neighbors = new List<GraphNode>();
        }
        public int Value { get; set; }
        public List<GraphNode> Neighbors;
        public bool Visited { get; set; }
        public GraphNode Previous { get; set; }
    }
}
