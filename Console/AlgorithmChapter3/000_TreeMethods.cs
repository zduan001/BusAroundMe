using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter3
{
    public class _000_TreeMethods
    {
        public TreeNodeWithCount CreateBST(int[] input)
        {
            if (input == null || input.Length == 0)
            {
                return null;
            }
            TreeNodeWithCount node = CreateBST(input, 0, input.Length - 1);
            return node;
        }

        private TreeNodeWithCount CreateBST(int[] input, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                return null;
            }

            int mid = (startIndex + endIndex) / 2;
            TreeNodeWithCount node = new TreeNodeWithCount() { Key = input[mid] };
            node.Left = CreateBST(input, startIndex, mid - 1);
            node.Right = CreateBST(input, mid + 1, endIndex);
            int count = 0;
            count += node.Left == null ? 0 : node.Left.Count;
            count += node.Right == null ? 0 : node.Right.Count;
            count++;
            node.Count = count;
            return node;
        }

        public int FindKthElement(TreeNodeWithCount root, int k)
        {
            if (root == null) return -1; // base case.

            int left = root.Left == null? 0: root.Left.Count;
            if(left +1 == k) 
            {
                return root.Key;
            }

            if (root.Count < k) return -1;
            if (k < left)
            {
                return FindKthElement(root.Left, k);
            }

            if (k > left + 1)
            {
                return FindKthElement(root.Right, k - left - 1);
            }

            return -1;
        }

        public int FindRank(TreeNodeWithCount root, int key)
        {
            if (root == null)
            {
                return -1;
            }

            if (root.Key == key)
            {
                return root.Left == null ? 1 : root.Left.Count + 1;
            }
            else
            {
                if (key < root.Key)
                {
                    return FindRank(root.Left, key);
                }
                else
                {
                    int left = root.Left == null? 1: root.Left.Count +1;
                    int right = FindRank(root.Right, key);
                    return right == -1 ? -1 : left + right;
                }
            }
        }

        public void Insert(TreeNodeWithCount root, int value)
        {
            if (value <= root.Key)
            {
                if (root.Left == null)
                {
                    TreeNodeWithCount node = new TreeNodeWithCount() { Key = value, Count = 1 };
                    root.Left = node;
                }
                else
                {
                    Insert(root.Left, value);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    TreeNodeWithCount node = new TreeNodeWithCount() { Key = value, Count = 1 };
                    root.Right = node;
                }
                else
                {
                    Insert(root.Right, value);
                }
            }

            int count = 0;
            count += root.Left == null ? 0 : root.Left.Count;
            count += root.Right == null ? 0 : root.Right.Count;
            count++;
            root.Count = count;
        }

        public void Delete(TreeNodeWithCount root, int value)
        {
        }
    }
}
