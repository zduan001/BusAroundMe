using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_051_To_75
{
    public class _051_FindPathSum
    {
        /*
         * Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.
         For example:
         Given the below binary tree and sum = 22,
                      5
                     / \
                    4   8
                   /   / \
                  11  13  4
                 /  \      \
                7    2      1

         return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.

         */
        public bool FindPathSum(TreeNode root, int value)
        {
            return FindPathSum(root.LeftChild, value, root.Value) || FindPathSum(root.RightChild, value, root.Value);
        }

        private bool FindPathSum(TreeNode root, int target, int sum)
        {
            if (root == null) return target == sum;
            return FindPathSum(root.LeftChild, target, sum + root.Value) || FindPathSum(root.RightChild, target, sum + root.Value);
        }

        /*
         Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.
         For example:
         Given the below binary tree and sum = 22,
                      5
                     / \
                    4   8
                   /   / \
                  11  13  4
                 /  \    / \
                7    2  5   1

         return
 
        [
           [5,4,11,2],
           [5,8,4,5]
        ]
         */

        /// <summary>
        /// I have to use post order traver to get the stack
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<List<int>> FindPathSumII(TreeNode root, int value)
        {
            List<List<int>> res = new List<List<int>>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            int sum = 0;
            s.Push(root);
            sum += root.Value;
            TreeNode prevNode = null;
            bool isBackTrack = false;
            while (s.Count != 0)
            {
                TreeNode node = s.Peek();
                if (!isBackTrack && node.LeftChild != null)
                {
                    s.Push(node.LeftChild);
                    sum += node.LeftChild.Value;
                    if (sum == value && node.LeftChild.LeftChild == null &&
                        node.LeftChild.RightChild == null)
                    {
                        AddList(s, res);
                    }
                    isBackTrack = false;
                    continue;
                }
                if (isBackTrack && node.RightChild != null && prevNode != node.RightChild)
                {
                    s.Push(node.RightChild);
                    sum += node.RightChild.Value;
                    if (sum == value && node.RightChild.LeftChild == null &&
                        node.RightChild.RightChild == null)
                    {
                        AddList(s, res);
                    }
                    isBackTrack = false;
                    continue;
                }
                
                node = s.Pop();
                sum -= node.Value;
                prevNode = node;
                isBackTrack = true;
            }
            return res;
        }

        private void AddList(Stack<TreeNode> s, List<List<int>> res)
        {
            List<int> tmp = new List<int>();
            foreach (TreeNode node in s)
            {
                tmp.Add(node.Value);
            }

            res.Add(tmp);
        }
    }
}
