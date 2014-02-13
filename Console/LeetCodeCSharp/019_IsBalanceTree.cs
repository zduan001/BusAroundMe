using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _019_IsBalanceTree
    {
        /*
         * http://leetcode.com/onlinejudge#question_110
         */
        public bool IsBalanceTree(TreeNode root, ref int depth)
        {
            if (root == null)
            {
                depth = 0;
                return true;
            }

            int leftDepth =0;
            int rightDepth = 0;
            if(!IsBalanceTree(root.LeftChild, ref leftDepth) ||
                !IsBalanceTree(root.RightChild, ref rightDepth))
            {
                return false;
            }

            if (Math.Abs(rightDepth - leftDepth) > 1)
            {
                return false;
            }

            depth = Math.Max(leftDepth, rightDepth) + 1;
            return true;
        }
    }
}
