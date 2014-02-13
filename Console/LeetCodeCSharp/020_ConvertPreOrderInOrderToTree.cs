using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _020_ConvertPreOrderInOrderToTree
    {
        /*
         * http://leetcode.com/onlinejudge#question_106
         */
        public TreeNode CreateTree(int[] preOrder, int preStartIndex, int preEndIndex, int[] inOrder, int inStartIndex, int inEndIndex)
        {
            if (preStartIndex > preEndIndex) return null;
            if (preStartIndex == preEndIndex) return new TreeNode(preOrder[preStartIndex]);

            int i = inStartIndex;
            while (inOrder[i] != preOrder[preStartIndex])
            {
                i++;
            }

            int leftLength = i - inStartIndex;
            int rightLength = inEndIndex - i;

            TreeNode root = new TreeNode(preOrder[preStartIndex]);
            root.LeftChild = CreateTree(preOrder, preStartIndex + 1, preStartIndex + leftLength, inOrder, inStartIndex, inStartIndex + leftLength-1);
            root.RightChild = CreateTree(preOrder, preEndIndex - rightLength+1, preEndIndex, inOrder, inEndIndex - rightLength+1, inEndIndex);

            return root;
        }
    }
}
