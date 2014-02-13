using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace console
{
    public class _008_ConverToBinaryTree
    {
        /// <summary>
        /// Given an array where elements are sorted in ascending order, convert it to a height balanced BST.
        /// </summary>
        /// <param name="input">input array should be sorted.</param>
        /// <returns>balanced BST</returns>
        public TreeNode ConvertSortArraytoBalancedBST(int[] input)
        {
            TreeNode root = Convert(input, 0, input.Length - 1);
            return root;
        }

        /// <summary>
        /// working recursive method for ConvertSortArraytoBalancedBST.
        /// </summary>
        /// <param name="input">input array</param>
        /// <param name="start">start index</param>
        /// <param name="end">end index;</param>
        /// <returns>tree created.</returns>
        public TreeNode Convert(int[] input, int start, int end)
        {
            if (start > end) return null;

            int mid = (start + end) / 2;
            TreeNode node = new TreeNode(input[mid]);
            node.LeftChild = Convert(input, start, mid - 1);
            node.RightChild = Convert(input, mid + 1, end);

            return node;
        }

        /// <summary>
        /// Given a singly linked list where elements are sorted in ascending order, convert it to a height balanced BST.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public TreeNode ConvertSortedLinkListtoBalancedBST(LinkListNode input)
        {
            int count = 0;
            LinkListNode tmp = input;
            while (tmp != null)
            {
                tmp = tmp.Next;
                count++;
            }
            int mid = count / 2;
            tmp = input;
            for (int i = 0; i < mid; i++)
            {
                tmp = tmp.Next;
            }
            TreeNode node = new TreeNode(tmp.Value);
            node.LeftChild = CreateNodeFromLinkList(input, 0, mid - 1);
            node.RightChild = CreateNodeFromLinkList(input, mid + 1, count);
            return node;
        }

        public TreeNode CreateNodeFromLinkList(LinkListNode head, int start, int end)
        {
            if (start > end) return null;
            int mid = (start + end) / 2;
            LinkListNode tmp = head;
            for (int i = 0; i < mid; i ++ )
            {
                tmp = tmp.Next;
            }

            if (tmp == null) return null;
            TreeNode node = new TreeNode(tmp.Value);
            node.LeftChild = CreateNodeFromLinkList(head, start, mid-1);
            node.RightChild = CreateNodeFromLinkList(head, mid + 1, end);
            return node;
        }


    }
}
