using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _015_MinDepth
    {
        /*
         * http://leetcode.com/onlinejudge#question_111
         */
        public int FindMinDepth(TreeNode root)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            int depth = 0;
            int minDepth = int.MaxValue;
            s.Push(root);
            depth ++;
            bool isBackTrack = false;
            TreeNode previous = null;
            while (s.Count != 0)
            {
                TreeNode tmp = s.Peek();
                if (previous == null)
                {
                    if (tmp.LeftChild != null)
                    {
                        s.Push(tmp.LeftChild);
                        depth++;
                    }
                    else if (tmp.RightChild != null)
                    {
                        s.Push(root.RightChild);
                        depth++;
                    }
                    else
                    {
                        minDepth = minDepth < depth ? minDepth : depth;
                        previous = s.Pop();
                        depth--;
                    }
                }
                else
                {
                    if (previous == tmp.LeftChild && tmp.RightChild != null)
                    {
                        s.Push(tmp.RightChild);
                        depth++;
                        previous = null;
                    }
                    else
                    {
                        previous = s.Pop();
                        depth--;
                    }
                }
            }
            return minDepth;
        }
    }
}
