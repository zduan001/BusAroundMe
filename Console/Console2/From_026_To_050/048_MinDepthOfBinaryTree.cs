using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_026_To_050
{
    public class _048_MinDepthOfBinaryTree
    {
        /*
         * Given a binary tree, find its minimum depth.
         * The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
         */
        /// <summary>
        /// Since all I need is a number, I can stop with the first node with null child in DFS.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MinDepth(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            q.Enqueue(null);
            int depth = 1;
            while (q.Count != 0)
            {
                TreeNode node = q.Dequeue();
                if (node == null)
                {
                    q.Enqueue(null);
                    depth++;
                    continue;
                }
                if (node.LeftChild == null && node.RightChild == null) return depth;
                if (node.LeftChild != null) q.Enqueue(node.LeftChild);
                if (node.RightChild != null) q.Enqueue(node.RightChild);
            }
            return depth;
        }

        /*
         * Given a binary tree, find its maximum depth.
         * The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
         */
        public int MaxDepth(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            q.Enqueue(null);
            int depth = 1;
            while (q.Count != 0)
            {
                TreeNode node = q.Dequeue();
                if (node == null)
                {
                    if (q.Count != 0)
                    {
                        q.Enqueue(null);
                        depth++;
                    }
                    continue;
                }
                if (node.LeftChild != null) q.Enqueue(node.LeftChild);
                if (node.RightChild != null) q.Enqueue(node.RightChild);
            }
            return depth;
        }
    }
}
