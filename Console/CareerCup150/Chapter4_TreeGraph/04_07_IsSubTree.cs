using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace CareerCup150.Chapter4_TreeGraph
{
    public class _04_07_IsSubTree
    {
        /*
         * You have two very large binary trees: T1, with millions of nodes, and T2, 
         * with hundreds of nodes. Create an algorithm to decide if T2 is a subtree of T1.
         */

        public bool IsASubTree(TreeNode root, TreeNode t1)
        {
            if (t1 == null) return true;
            if (root == null) return false;

            if (root.Value != t1.Value)
            {
                return IsASubTree(root.LeftChild, t1) || IsASubTree(root.RightChild, t1);
            }
            else
            {
                return IsASubTree(root.LeftChild, t1.LeftChild) && IsASubTree(root.RightChild, t1.RightChild);
            }
        }
    }
}
