using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.G_Code
{
    public class G_008_PrePostOrder
    {
        /*
         * 
         * Given preorder and inorder traversal of a tree, construct the binary tree.
         */
        public TreeNode ConstructTree(int[] preorder, int preStart, int preEnd, int[] inorder, int inStart, int inEnd)
        {
            if (preStart > preEnd) return null;
            if (inStart > inEnd) return null;
            int value = preorder[preStart];
            int indexOfValue = -1;
            for (int i = inStart; i <= inEnd; i++)
            {
                if (inorder[i] == value)
                {
                    indexOfValue = i;
                    break;
                }
            }
            if (indexOfValue == -1) throw new Exception();

            TreeNode root = new TreeNode(value);
            int leftLength = indexOfValue - inStart;
            int rightLength = inEnd - indexOfValue;

            root.LeftChild = ConstructTree(preorder, preStart + 1, preStart + leftLength, inorder, inStart, indexOfValue - 1);
            root.RightChild = ConstructTree(preorder, preStart + leftLength + 1, preEnd, inorder, indexOfValue + 1, inEnd);

            return root;
        }
    }
}
