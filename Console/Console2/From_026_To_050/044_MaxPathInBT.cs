using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_026_To_050
{
    public class _044_MaxPathInBT
    {

        /*
         * Given a binary tree, find the maximum path sum. 

            The path may start and end at any node in the tree. 

            For example:
             Given the below binary tree, 
                   1
                  / \
                 2   3
 

            Return 6. 

         */
        /// <summary>
        /// This question is kind of tricky, you have to conider if the root is a negative number so the max path might not include the root
        /// it might be only have path from 1 site of the tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int GetMaxPathSumInBinaryTree(TreeNode root)
        {
            int left = 0;
            int right = 0;
            int leftSum = Worker(root.LeftChild, ref left);
            int rightSum = Worker(root.RightChild, ref right);

            int res = left + right + root.Value;
            res = Math.Max(Math.Max(res, leftSum), rightSum);
            return res;

        }

        public int Worker(TreeNode root, ref int maxSum)
        {
            if (root == null)
            {
                maxSum = 0;
                return 0;
            }
            int left= 0;
            int right =0;

            int leftSum = Worker(root.LeftChild, ref left); 
            int rightSum = Worker(root.RightChild, ref right);
            maxSum = left>right? left + root.Value:right+ root.Value;
            
            int res = left+right+root.Value;
            res = Math.Max( Math.Max(res, leftSum), rightSum);
            return res;
        }
    }
}
