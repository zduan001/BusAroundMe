using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_014_InvervalTree
    {
        /*
         * 
            a set of intervals, how to tell if a given value is in any of the  
            intervals 
            讨论了overlapping的情况，interval tree，etc
         */
        // naive method: scan through the ranges and select one.
        /*MiT introduction to algorithm method:
         * INTERVAL-SEARCH(T, i)
            1  x ← root[T]
            2  while x ≠ nil[T] and i does not overlap int[x]
            3      do if left[x] ≠ nil[T] and max[left[x]] ≥ low[i]
            4            then x ← left[x]
            5            else x ← right[x]
            6  return x
         * 
         */

        public class IntervalTreeNode
        {
            public int Left;
            public int Right;
            public int MaxValueOfSubTree;
            public IntervalTreeNode LeftNode;
            public IntervalTreeNode RightNode;
        }

        /// <summary>
        /// for a single value, just set the left and right of the value to the same number.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public IntervalTreeNode IntervalTreeSearch(IntervalTreeNode root, IntervalTreeNode value)
        {
            IntervalTreeNode tmp = root;
            while (tmp != null && tmp.Left > value.Right && tmp.Right < value.Left)
            {
                if (tmp.LeftNode != null && value.Right < tmp.LeftNode.MaxValueOfSubTree)
                {
                    tmp = tmp.LeftNode;
                }
                else
                {
                    tmp = tmp.RightNode;
                }
            }
            return tmp;
        }
    }
}
