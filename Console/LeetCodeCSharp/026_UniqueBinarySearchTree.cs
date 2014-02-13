using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra;

namespace LeetCodeCSharp
{
    public class _026_UniqueBinarySearchTree
    {
        /*
         * http://leetcode.com/onlinejudge#question_95
         */
        public List<TreeNode> CreateTree(int left, int right)
        {
            List<TreeNode> res = new List<TreeNode>();
            if (left > right) return new List<TreeNode>(){null};

            for (int i = left; i <= right; i++)
            {
                List<TreeNode> leftList = CreateTree(left, i - 1);
                List<TreeNode> rightList = CreateTree(i + 1, right);

                foreach (TreeNode l in leftList)
                {
                    foreach (TreeNode r in rightList)
                    {
                        TreeNode currentRoot = new TreeNode(i);
                        currentRoot.LeftChild = CloneTree(l);
                        currentRoot.RightChild = CloneTree(r);
                        res.Add(currentRoot);
                    }
                }
            }

            return res;
        }

        private TreeNode CloneTree(TreeNode root)
        {
            if (root == null) return null;

            TreeNode newRoot = new TreeNode(root.Value);
            newRoot.LeftChild = CloneTree(root.LeftChild);
            newRoot.RightChild = CloneTree(root.RightChild);
            return newRoot;
        }

        public int FindCountOfTree(int left, int right)
        {
            if (left > right) return 1;
            int sum = 0;
            for (int i = left; i <= right; i++)
            {
                int m = FindCountOfTree(left, i - 1);
                int n = FindCountOfTree(i + 1, right);
                sum += m*n;
            }
            return sum;
        }
    }
}
