using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _021_ZigzagTree
    {
        /*
         * http://leetcode.com/onlinejudge#question_103
         */
        public List<int> PrintZigzagTree(TreeNode root)
        {
            bool forward = true;
            Stack<TreeNode> s1 = new Stack<TreeNode>();
            Stack<TreeNode> s2 = new Stack<TreeNode>();
            s1.Push(root);
            List<int> res = new List<int>();
            while (s1.Count != 0)
            {
                while (s1.Count != 0)
                {
                    TreeNode node = s1.Pop();
                    if (forward)
                    {
                        if (node.LeftChild != null) s2.Push(node.LeftChild);
                        if (node.RightChild != null) s2.Push(node.RightChild);
                    }
                    else
                    {
                        if (node.RightChild != null) s2.Push(node.RightChild);
                        if (node.LeftChild != null) s2.Push(node.LeftChild);
                    }
                    res.Add(node.Value);
                }
                forward = !forward;
                s1 = s2;
                s2 = new Stack<TreeNode>();
            }

            return res;


        }
    }
}
