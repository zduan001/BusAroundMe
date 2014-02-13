using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _007_BinaryTreeMaxPathSum
    {
        /*
         * http://leetcode.com/onlinejudge#question_124
         */
        public int FindMaxPathSum(TreeNode root)
        {
            int left = 0;
            int right = 0;
            int leftcrossPath = 0;
            int rightCrossPath = 0;
            left = FindPathSum(root.LeftChild, ref leftcrossPath);
            right = FindPathSum(root.RightChild, ref rightCrossPath);

            int sum = left + right + root.Value;

            return Math.Max(rightCrossPath, Math.Max(sum, leftcrossPath));
        }

        private int FindPathSum(TreeNode root, ref int crosspath)
        {
            if (root == null)
            {
                crosspath = 0;
                return 0;
            }

            int leftPathSum =0;
            int rightPathSum =0;
            int left = FindPathSum(root.LeftChild, ref leftPathSum);
            int right = FindPathSum(root.RightChild, ref rightPathSum);

            int sum = left + right + root.Value;
            crosspath = Math.Max(sum, Math.Max(leftPathSum, rightPathSum));

            int res = left > right ? left + root.Value : right + root.Value;
            return res;
        }
    }
}
