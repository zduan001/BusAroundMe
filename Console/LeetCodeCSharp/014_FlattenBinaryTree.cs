using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _014_FlattenBinaryTree
    {
        /*
         * http://leetcode.com/onlinejudge#question_115
         */
        public void FlattenBinaryTree(TreeNode root, ref TreeNode header, ref TreeNode end)
        {
            if (root != null && root.LeftChild == null && root.RightChild == null)
            {
                header = root;
                end = root;
                return;
            }

            TreeNode tmpHeader = null;
            TreeNode tmpEnd = null;
            TreeNode rightTmpHeader = null;
            TreeNode rightTmpEnd = null;

            if (root.LeftChild != null)
            {
                FlattenBinaryTree(root.LeftChild, ref tmpHeader, ref tmpEnd);
            }
            if (root.RightChild != null)
            {
                FlattenBinaryTree(root.RightChild, ref rightTmpHeader, ref rightTmpEnd);
            }

            root.LeftChild = null;
            if (tmpHeader != null && rightTmpHeader != null)
            {
                root.RightChild = tmpHeader;
                tmpEnd.RightChild = rightTmpHeader;
                header = root;
                end = rightTmpEnd;
                return;
            }
            else if (tmpHeader == null && rightTmpHeader != null)
            {
                root.RightChild = rightTmpHeader;
                header = root;
                end = rightTmpEnd;
                return;
            }
            else if (tmpHeader != null && rightTmpHeader == null)
            {
                root.RightChild = tmpHeader;
                header = root;
                end = tmpEnd;
                return;
            }

            header = root;
            end = root;
            return;
        }
    }
}
