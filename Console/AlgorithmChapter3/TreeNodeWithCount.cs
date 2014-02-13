using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter3
{
    public class TreeNodeWithCount
    {
        public int Key { get; set; }
        public TreeNodeWithCount Left { get; set; }
        public TreeNodeWithCount Right { get; set; }
        public int Count { get; set; }
    }
}
