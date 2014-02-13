using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace CareerCup150.Chapter4_TreeGraph
{
    public class _04_06_LCA
    {
        /*
         * Design an algorithm and write code to find the first common ancestor of two nodes in a binary tree. 
         * Avoid storing additional nodes in a data structure. NOTE: This is not necessarily a binary search tree.
         */
        public TreeNode FindLCA(TreeNode n1, TreeNode n2, TreeNode root)
        {
            if (root == null) return null;
            if (root == n1 || root == n2) return root;

            TreeNode left = FindLCA(n1, n2, root.LeftChild);
            TreeNode right = FindLCA(n1, n2, root.RightChild);

            if (left != null && right != null)
            {
                return root;
            }
            else if (left == null && right == null)
            {
                return null;
            }

            return left != null ? left : right;
        }
    }
}
