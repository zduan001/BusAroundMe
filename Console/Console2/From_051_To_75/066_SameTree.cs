using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_051_To_75
{
    class _066_SameTree
    {
        /*
         * Given two binary trees, write a function to check if they are equal or not. 
           Two binary trees are considered equal if they are structurally identical and the nodes have the same value.
         */
        /// <summary>
        /// this is not a hard question.
        /// </summary>
        /// <param name="tree1"></param>
        /// <param name="tree2"></param>
        /// <returns></returns>
        public bool VerifySameTree(TreeNode tree1, TreeNode tree2)
        {
            if (tree1 == null && tree2 == null)
            {
                return true;
            }
            else if (tree1 == null && tree2 != null)
            {
                return false;
            }
            else if (tree1 != null && tree2 == null)
            {
                return false;
            }
            else
            {
                return tree1.Value == tree2.Value && VerifySameTree(tree1.LeftChild, tree2.LeftChild) && VerifySameTree(tree1.RightChild, tree2.RightChild);
            }
        }
    }
}
