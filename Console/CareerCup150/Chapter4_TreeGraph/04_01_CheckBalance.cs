using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace CareerCup150.Chapter4_TreeGraph
{
    public class _04_01_CheckBalance
    {
        public bool IsBalanceTree(TreeNode root)
        {
            return !(Math.Abs(HeighOfTree(root.LeftChild) - HeighOfTree(root.RightChild)) > 1);
            
        }

        private int HeighOfTree(TreeNode root)
        {
            if (root == null) return 0;
            return Math.Max(HeighOfTree(root.LeftChild), HeighOfTree(root.RightChild))+1;
        }
    }
}
