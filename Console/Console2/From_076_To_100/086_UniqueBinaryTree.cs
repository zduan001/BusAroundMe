using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_076_To_100
{
    public class _086_UniqueBinaryTree
    {
        /*
         Given n, how many structurally unique BST's (binary search trees) that store values 1...n?
         For example,
         Given n = 3, there are a total of 5 unique BST's. 
           1         3     3      2      1
            \       /     /      / \      \
             3     2     1      1   3      2
            /     /       \                 \
           2     1         2                 3
         */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public int UniqueBinaryTree(int start, int end)
        {
            if (end <= start) return 1;
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                count += (UniqueBinaryTree(start, i - 1) * UniqueBinaryTree(i + 1, end));
            }
            return count;
        }

        public int UniqueBinaryTreeII(int n)
        {
            if (n <= 1) return 1;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                count += (UniqueBinaryTreeII(i - 1) * UniqueBinaryTreeII(n - i));
            }
            return count;
        }

        /*
        Given n, generate all structurally unique BST's (binary search trees) that store values 1...n.
        For example,
        Given n = 3, your program should return all 5 unique BST's shown below.
         */
        public List<TreeNode> AllBSTs(int start, int end)
        {
            if (end < start) return new List<TreeNode>() { null};
            if (end == start ) return new List<TreeNode>() { new TreeNode(start) };
            List<TreeNode> res = new List<TreeNode>();
            for (int i = start; i <= end; i++)
            {
                List<TreeNode> left = AllBSTs(start, i-1);
                List<TreeNode> right = AllBSTs(i + 1, end);
                foreach (TreeNode lnode in left)
                {
                    foreach (TreeNode rnode in right)
                    {
                        TreeNode root = new TreeNode(i);
                        // I actually have to clone the tree here otherwise I may just change the same tree again adn again.
                        root.LeftChild = lnode;
                        root.RightChild = root;
                        res.Add(root);
                    }
                }
            }
            return res;

        }
    }
}
