using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace CareerCup150.Chapter4_TreeGraph
{
    public class _04_05_FindNextNode
    {
        /*
         * Write an algorithm to find the ‘next’ node (i.e., in-order successor) of a given 
         * node in a binary search tree where each node has a link to its parent.
         */
        public TreeNodeWithP FindNext(TreeNodeWithP input)
        {
            TreeNodeWithP right = (TreeNodeWithP) input.RightChild;
            if (right != null)
            {
                right = LeftMostChild(right);
                return right as TreeNodeWithP;
            }
            else
            {
                TreeNodeWithP parent = (TreeNodeWithP) input.Parent;
                if (parent == null) return null;
                TreeNodeWithP tmp = input;
                while (tmp != parent.LeftChild)
                {
                    tmp = parent;
                    parent = parent.Parent;
                }
                right = (TreeNodeWithP)parent.RightChild;
                if (right != null)
                {
                    right = LeftMostChild(right);
                    return right as TreeNodeWithP;
                }
            }
            return null;
        }

        private TreeNodeWithP LeftMostChild(TreeNodeWithP root)
        {
            if (root == null) return null;
            while (root.LeftChild != null) root = (TreeNodeWithP)root.LeftChild;
            return root;
        }

        public class TreeNodeWithP : TreeNode
        {
            public TreeNodeWithP(int i)
                : base(i)
            {
            }
            public TreeNodeWithP Parent { get; set; }
        }
    }
}
