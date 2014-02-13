using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace console
{
    public class _035_BinaryTreeMaximumSumPath
    {
        /// <summary>
        /// How to find maximum path sum in a binary tree.
        /// The path need not be a top-bottom, can start and end nodes need not be root 
        /// or leaf, path can start in left/right subtree and end in right/left subtree 
        /// wrt any node.
        /// 
        /// Careercup上看到的，感觉里面没有正确的解答。求版里大神指教。题目里如果没有最
        /// 后一句话就好办了，加上最后那句话感觉好复杂。
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int FindMaxSumPath(TreeNode root)
        {
            int under = 0;
            int res = FindMaxSumPath(root, ref under);

            return res;
        }

        /// <summary>
        /// Working method.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="maxUnder"></param>
        /// <returns></returns>
        public int FindMaxSumPath(TreeNode root, ref int maxUnder)
        {
            if (root == null)
            {
                maxUnder = 0;
                return 0;
            }

            int leftMaxUnder = int.MinValue;
            int rightMaxUnder = int.MinValue;
            int leftMax = FindMaxSumPath(root.LeftChild, ref leftMaxUnder);
            int rightMax = FindMaxSumPath(root.RightChild, ref rightMaxUnder);

            int res = Math.Max(Math.Max(leftMax, rightMax), leftMaxUnder + rightMaxUnder + root.Value);
            maxUnder = Math.Max(leftMaxUnder, rightMaxUnder) + root.Value;

            return res;
        }
    }
}
