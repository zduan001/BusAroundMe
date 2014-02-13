using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _024_RecoverBST
    {
        /*
         * http://leetcode.com/onlinejudge#question_99
         */
        public void RecoverBST(TreeNode root, int left, int right)
        {
            // http://blog.unieagle.net/2012/10/16/leetcode%E9%A2%98%E7%9B%AE%EF%BC%9Arecover-binary-search-tree/
            // this site has a interative solution. need to take sometime to view it.

            TreeNode n1 = null;
            TreeNode n2 = null;
            FindWrongNode(root, int.MinValue, int.MaxValue, ref n1, ref n2);
            int tmp = n1.Value;
            n1.Value = n2.Value;
            n2.Value = tmp;
        }

        public void FindWrongNode(TreeNode root, int left, int right, ref TreeNode n1, ref TreeNode n2)
        {
            if (n1 != null && n2 != null) return;
            if (root == null) return;
            if (root.Value < left || root.Value > right)
            {
                if (n1 != null)
                {
                    n1 = root;
                }
                else if (n2 != null)
                {
                    n2 = root;
                }
            }
            FindWrongNode(root.LeftChild, left, root.Value, ref n1, ref n2);
            FindWrongNode(root.RightChild, root.Value, right, ref n1, ref n2);
        }

        public bool IsBST(TreeNode root, int left, int right)
        {
            if (root == null) return true;
            if (root.Value < left || root.Value > right) return false;
            return IsBST(root.LeftChild, left, root.Value) || IsBST(root.RightChild, root.Value, right);
        }
    }
}
