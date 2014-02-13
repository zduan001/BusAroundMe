using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_076_To_100
{
    public class _082_SymetricTree
    {
        /*
         * Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).

             For example, this binary tree is symmetric: 
                1
               / \
              2   2
             / \ / \
            3  4 4  3
            But the following is not:
                1
               / \
              2   2
               \   \
               3    3
         */
        /// <summary>
        /// pretty straight forward
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymetricTree(TreeNode root)
        {
            return IsSymetricTree(root.LeftChild, root.RightChild);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root1"></param>
        /// <param name="root2"></param>
        /// <returns></returns>
        public bool IsSymetricTree(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return true;
            if((root1 != null && root2 == null)|| (root1 == null && root2 != null))
            {
                return false;
            }
            if( root1.Value == root1.Value && IsSymetricTree(root1.LeftChild, root2.RightChild) && IsSymetricTree(root1.RightChild, root2.LeftChild))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
