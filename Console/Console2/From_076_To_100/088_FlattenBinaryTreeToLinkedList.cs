using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_076_To_100
{
    public class _088_FlattenBinaryTreeToLinkedList
    {
        /*
         * Given a binary tree, flatten it to a linked list in-place. 

            For example,
             Given 
                     1
                    / \
                   2   5
                  / \   \
                 3   4   6
 
            The flattened tree should look like:
                1
                \
                 2
                  \
                   3
                    \
                     4
                      \
                       5
                        \
                         6
         */
        public void FlattenTree(TreeNode root)
        {
            if (root == null) return;
            TreeNode left = root.LeftChild;
            if (left != null)
            {
                TreeNode tmp = root;
                while (tmp.RightChild != null)
                {
                    tmp = tmp.RightChild;
                }
                tmp.RightChild = left;
                tmp.LeftChild = null;
            }
            FlattenTree(root.RightChild);
            return;
        }
    }
}
