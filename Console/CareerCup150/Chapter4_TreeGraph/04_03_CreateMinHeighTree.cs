using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace CareerCup150.Chapter4_TreeGraph
{
    public class _04_03_CreateMinHeighTree
    {
        /*
         * Given a sorted (increasing order) array, write an algorithm to create a binary tree with minimal height.
         */
        public TreeNode CreateMinHeihtTree(int[] input)
        {
            TreeNode root = Worker(input, 0, input.Length - 1);
            return root;
        }

        public TreeNode Worker(int[] input, int a, int b)
        {
            if (a > b) return null;
            int mid = (a + b) / 2;
            TreeNode node = new TreeNode(input[mid]);
            node.LeftChild = Worker(input, a, mid - 1);
            node.RightChild = Worker(input, mid + 1, b);
            return node;
        }
    }
}
