using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class ConvertBinaryTreeToDll
    {
        /*
         * http://www.geeksforgeeks.org/in-place-convert-a-given-binary-tree-to-doubly-linked-list/
         * Given a Binary Tree (Bt), convert it to a Doubly Linked List(DLL). The left and right 
         * pointers in nodes are to be used as previous and next pointers respectively in converted DLL
         */
        public TreeNode Convert(TreeNode root)
        {
            TreeNode first = null;
            TreeNode last = null;
            Convert(root, ref first, ref last);
            while (root.LeftChild != null)
            {
                root = root.LeftChild;
            }
            return root;
        }

        public void Convert(TreeNode root, ref TreeNode left, ref TreeNode right)
        {
            if (root == null)
            {
                left = null;
                right = null;
                return;
            }

            TreeNode first = null;
            TreeNode previous = null;
            TreeNode next = null;
            TreeNode last = null;

            Convert(root.LeftChild, ref first, ref previous);
            Convert(root.RightChild, ref next, ref last);
            root.LeftChild = previous;

            if (previous != null)
            {
                previous.RightChild = root;
            }
            root.RightChild = next;
            if (next != null)
            {
                next.LeftChild = root;
            }

            left = first == null? root: first;
            right = last == null? root: last;
        }
    }
}
