using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace console
{
    public class _067_UniqueBinarySearchTree
    {
        /// <summary>
        /// Given n, how many structurally unique BST's (binary search trees) that store values 1...n?
        /// For example,
        /// Given n = 3, there are a total of 5 unique BST's.
        ///  1      3   3    2   1
        ///   \     /    /    / \   \
        ///   3   2    1   1  3    2
        ///  /   /      \             \
        /// 2  1        2            3 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int UniqueBST(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += UniqueBST(i - 1) * UniqueBST(n - i);
            }

            return sum;
        }

        /// <summary>
        /// Given n, generate all structurally unique BST's (binary search trees) that store values 1...n.
        /// For example,
        /// Given n = 3, your program should return all 5 unique BST's shown below.
        /// The different between this method and last method is that this method need to return all the tree.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<TreeNode> FindAllUniqueBSTII(int n)
        {
            return UniqueBSTII(0, n - 1);
        }

        /// <summary>
        ///  working method for the last method.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public List<TreeNode> UniqueBSTII(int left, int right)
        {
            List<TreeNode> res = new List<TreeNode>();
            if (left > right) return new List<TreeNode>(){null};
            if (left == right)
            {
                TreeNode root = new TreeNode(left);
                res = new List<TreeNode>() { root };
                return res;
            }

            for (int i = left; i <= right; i++)
            {
                List<TreeNode> leftTree = UniqueBSTII(left, i - 1);
                List<TreeNode> rightTree = UniqueBSTII(i + 1, right);

                
                foreach(TreeNode leftNode in leftTree)
                {
                    foreach(TreeNode rightNode in rightTree)
                    {
                        TreeNode root = new TreeNode(i);
                        root.LeftChild = leftNode;
                        root.RightChild = rightNode;
                        res.Add(root);
                    }
                }
            }

            return res;
        }
    }
}
