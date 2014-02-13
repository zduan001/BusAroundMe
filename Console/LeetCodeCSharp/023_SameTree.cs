using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra;

namespace LeetCodeCSharp
{
    public class _023_SameTree
    {
        /*
         * http://leetcode.com/onlinejudge#question_100
         */
        public bool IsSameTree(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return true;
            if (root1 == null && root2 != null) return false;
            if (root1 != null && root2 == null) return false;

            if (root1.Value != root1.Value) return false;

            if (IsSameTree(root1.LeftChild, root2.LeftChild) && 
                IsSameTree(root1.RightChild, root2.RightChild))
            {
                return true;
            }

            return false;
        }
    }
}
