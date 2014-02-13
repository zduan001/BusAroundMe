using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_001_To_025
{
    public class _021_ContructBSTFromPostOrderArray
    {

        /*
         * construct a BST from an array, this array is a post order travel of the tree
         * this need to be done in O(n) time.
         */

        public TreeNode CreateBST(int[] input)
        {
            if (input == null || input.Length == 0) return null;
            int leftNodeIndex = -1;
            TreeNode res = Worker(input.Length - 1, input, ref leftNodeIndex, int.MinValue, int.MaxValue);
            if (leftNodeIndex >= 0) return null;
            return res;
        }

        public TreeNode Worker(int index, int[] input, ref int returnIndex, int min, int max)
        {
            if (index < 0) return null;
            int a = input[index];
            TreeNode node = new TreeNode(a);
            if (index == 0) return node;

            if (input[index - 1] > max) throw new Exception();

            if (input[index - 1] < min )
            {
                returnIndex = index - 1;
            }
            else
            {
                int nextIndex = index - 1;
                if (a < input[index - 1])
                {
                    int leftNodeIndex = -1;
                    node.RightChild = Worker(index - 1, input, ref leftNodeIndex, a,max);
                    nextIndex = leftNodeIndex;
                }
                int parentLeftChild = -1;
                node.LeftChild = Worker(nextIndex, input, ref parentLeftChild, min,a);
                returnIndex = parentLeftChild;
            }
            return node;
        }

        /*
         * Can I the recreate BST using iterative method
         */

        public TreeNode CreatBSTIterative(int[] input)
        {
            return null;
        }

        /*
         * Check if an array can be a post order travel of BST tree
         * this method only need to check if the array is BST postorder travel.
         * no need to construct one.
         */
        public bool VerifyPostOrder(int[] input)
        {
            int res = ScanPostOrderBSTArray(input, input.Length - 1, int.MaxValue, int.MinValue);
            return res < 0;
        }

        private int ScanPostOrderBSTArray(int[] input, int index, int max, int min)
        {
            if (index < 0 || input[index] > max || input[index] < min)
            {
                return index;
            }

            int leftChildIndex = ScanPostOrderBSTArray(input, index - 1, max, input[index]);
            int res = ScanPostOrderBSTArray(input, leftChildIndex, input[index], min);

            return res;
        }
    }
}
