using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace CareerCup150.Chapter4_TreeGraph
{
    public class _04_08_SumPath
    {
        /*
         * You are given a binary tree in which each node contains a value. Design an algorithm to print all paths 
         * which sum up to that value. Note that it can be any path in the tree - it does not have to start at the root.
         */
        public List<int> GetAllPath(TreeNode root, int value)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            Stack<TreeNode> r = new Stack<TreeNode>();
            s.Push(root);
            int sum = 0;
            TreeNode tmp = null;

            while (s.Count != 0)
            {
                bool pushed = false;
                if (s.Peek().LeftChild != null)
                {
                    s.Push(s.Peek().LeftChild);
                    pushed = true;
                }
                else if (s.Peek().RightChild != null)
                {
                    s.Push(s.Peek().RightChild);
                    pushed = true;
                }
                else
                {
                    s.Pop();
                }
                if (pushed)
                {
                    sum = 0;
                    while (s.Count != 0)
                    {
                        tmp = s.Pop();
                        r.Push(tmp);
                        sum = tmp.Value++;
                        if (sum == value)
                        {
                            List<int> list = new List<int>();
                            while (r.Count != 0)
                            {
                                tmp = r.Pop();
                                list.Add(tmp.Value);
                                s.Push(tmp);
                            }
                        }
                    }
                }
            }
            return res;
        }
    }
}
