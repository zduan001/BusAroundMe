using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    class _018_BinaryTreeLevelOrderTraversal
    {
        /*
         * http://leetcode.com/onlinejudge#question_107
         */
        public void LevelTraversal(TreeNode root)
        {
            int maxDepth = MaxDepth(root);
            for (int i = maxDepth; i >= 0; i++)
            {
                PrintTreeByLevel(root, i);
            }
        }

        private void PrintTreeByLevel(TreeNode root, int level)
        {
            if (level == 0 && root != null)
            {
                // print out root;
            }

            PrintTreeByLevel(root.LeftChild, level - 1);
            PrintTreeByLevel(root.RightChild, level - 1);
        }

        private int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftDepth = MaxDepth(root.LeftChild);
            int rightDepth = MaxDepth(root.RightChild);

            return Math.Max(leftDepth, rightDepth) + 1;

        }
    }
}

