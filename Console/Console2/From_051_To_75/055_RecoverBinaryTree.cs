using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_051_To_75
{
    /*
     * Two elements of a binary search tree (BST) are swapped by mistake.
     * Recover the tree without changing its structure. 
     */
    public class _055_RecoverBinaryTree
    {
        /// <summary>
        /// easiest way is inorder travel to an array and to see which 2 elements are out of line
        /// then swap the value.
        /// but here I am trying to be smart, no success yet. 
        /// </summary>
        /// <param name="root"></param>
        public void RecoverBinaryTree(TreeNode root)
        {
            TreeNode node1 = null;
            TreeNode node2 = null;
            FindMisPlacedNode(root, int.MinValue, int.MaxValue, ref node1, ref node2);

            if (node1 != null && node2 != null)
            {
                int tmp = node1.Value;
                node1.Value = node2.Value;
                node2.Value = tmp;
            }
        }


        private void FindMisPlacedNode(TreeNode root, int left, int right, ref TreeNode node1, ref TreeNode node2)
        {
            if(root == null) return;
            if (root.Value < left || root.Value > right)
            {
                if (node1 == null)
                {
                    node1 = root;
                    return;
                }
                else
                {
                    node2 = root;
                    return;
                }
            }
            if (node1 == null || node2 == null)
            {
                FindMisPlacedNode(root.LeftChild, left, root.Value, ref node1, ref node2);
                FindMisPlacedNode(root.RightChild, root.Value, right, ref node1, ref node2);
            }
        }
    }
}
