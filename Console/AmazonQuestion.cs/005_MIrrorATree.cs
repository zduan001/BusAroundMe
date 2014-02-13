using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestion.cs
{
    public class _005_MIrrorATree
    {
        /*
         * 给一个二叉树，如何把它转成他的mirro image。
         */
        public TreeNode MirrorAtree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode left = root.LeftChild;
            TreeNode right = root.RightChild;
            root.LeftChild = MirrorAtree(right);
            root.RightChild = MirrorAtree(left);
            return root;
        }
    }
}
