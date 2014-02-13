using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra;

namespace LeetCodeCSharp
{
    public class _022_IsASymmetricTree
    {
        /*
         * http://leetcode.com/onlinejudge#question_101
         */
		public bool IsSymmetricTree(TreeNode root)
        {
            if (IsSymmetricNode(root.LeftChild, root.RightChild))
            {
                return true;
            }

            return false;
        }

        public bool IsSymmetricNode(TreeNode n1, TreeNode n2)
        {
            if (n1 == null && n2 == null) return true;
            if (n1 == null && n2 != null) return false;
            if (n1 != null && n2 == null) return false;
            if (n1.Value != n2.Value) return false;

			// if reach here, n1.Value == n2.Value
            if (IsSymmetricNode(n1.LeftChild, n2.RightChild) && IsSymmetricNode(n1.RightChild, n2.LeftChild))
            {
                return true;
            }
            return false;
        }
    }
}
