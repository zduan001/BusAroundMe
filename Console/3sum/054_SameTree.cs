using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace console
{
    public class _054_SameTree
    {
        /// <summary>
        /// Given two binary trees, write a function to check if they are equal or not.
        /// Two binary trees are considered equal if they are structurally identical and 
        /// the nodes have the same value.
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public bool VerifySameTree(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
            {
                return true;
            }
            else if (t1 == null)
            {
                return false;
            }
            else if (t2 == null)
            {
                return false;
            }
            else if (t1.Value == t2.Value)
            {
                return VerifySameTree(t1.LeftChild, t2.LeftChild) && VerifySameTree(t1.RightChild, t2.RightChild);
            }
            else
            {
                return false;
            }
        }
    }
}
