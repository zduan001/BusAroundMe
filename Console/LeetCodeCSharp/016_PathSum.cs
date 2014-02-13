using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _016_PathSum
    {
        /*
         * http://leetcode.com/onlinejudge#question_113
         */
        public List<List<int>> FindAllPathSum(TreeNode root, int targetValue)
        {
            List<List<int>> res = new List<List<int>>();
            List<TreeNode> tmp = new List<TreeNode>() {root};
            int sum = root.Value;
            Solve(root, res, tmp, sum, targetValue);
            return res;
        }

        private void Solve(TreeNode root, List<List<int>> res, List<TreeNode> tmp, int sum, int target)
        {
            if (sum == target && 
                tmp[tmp.Count-1].LeftChild == null && 
                tmp[tmp.Count-1].RightChild == null)
            {
                List<int> l = new List<int>();
                foreach (TreeNode node in tmp)
                {
                    l.Add(node.Value);
                }
                res.Add(l);
                return;
            }

            if (root.LeftChild != null)
            {
                tmp.Add(root.LeftChild);
                sum += root.LeftChild.Value;
                Solve(root.LeftChild, res, tmp, sum, target);
                sum -= root.LeftChild.Value;
                tmp.Remove(root.LeftChild);
            }

            if (root.RightChild != null)
            {
                tmp.Add(root.RightChild);
                sum += root.RightChild.Value;
                Solve(root.RightChild, res, tmp, sum, target);
                sum -= root.RightChild.Value;
                tmp.Remove(root.RightChild);
            }
        }
    }
}
