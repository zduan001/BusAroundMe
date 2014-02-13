using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestion.cs
{
    public class _003_RebuildTree
    {
        /*
         * 用pre-order in-order sequence重构binary tree.
         * I have to assume in pre order and in order array there is no dup element.
         * http://www.mitbbs.com/article_t/JobHunting/32026413.html
         * http://leetcode.com/2011/04/construct-binary-tree-from-inorder-and-preorder-postorder-traversal.html
         * 
         */
        public TreeNode RebuildTree(int[] preOrder, int preStartIndex, int preEndIndex, int[] inOrder, int inStartIndex, int inEndIndex)
        {
            if (preStartIndex > preEndIndex)
            {
                return null;
            }

            if (preEndIndex - preStartIndex != inEndIndex - inStartIndex)
            {
                // throw exception.
                return null;
            }

            int tmp = preOrder[preStartIndex];
            int index = -1;

            for (int i = inStartIndex; i <= inEndIndex; i++)
            {
                if (inOrder[i] == tmp)
                {
                    index = i;
                    break;
                }
            }

            // the reason of creating these 2 temp variable to get length is to make 
            // code clear.
            int leftLength = index - 1 - inStartIndex;
            int rightLength = inEndIndex - index - 1;

            TreeNode node = new TreeNode(tmp);
            node.LeftChild = RebuildTree(preOrder, preStartIndex + 1, preStartIndex + 1+ leftLength, inOrder, inStartIndex, index - 1);
            node.RightChild = RebuildTree(preOrder, preEndIndex - rightLength, preEndIndex, inOrder, index + 1, inEndIndex);
            return node;
        }
    }
}
