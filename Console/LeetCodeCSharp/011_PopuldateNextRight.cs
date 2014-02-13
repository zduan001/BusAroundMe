using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _011_PopuldateNextRight
    {
        /*
         * http://leetcode.com/onlinejudge#question_117
         */
        public void PopuldateNextRight(TreeNode node, TreeNode parent)
        {
            if (parent != null && parent.LeftChild == node && parent.RightChild != null)
            {
                parent.LeftChild.Next = parent.RightChild;
            }
            else if (parent != null && parent.Next != null)
            {
                if (parent.Next.LeftChild != null)
                {
                    node.Next = parent.Next.LeftChild;
                }
                else
                {
                    node.Next = parent.Next.RightChild;
                }
            }

            if (node.RightChild != null)
            {
                PopuldateNextRight(node.RightChild, node);
            }

            if (node.LeftChild != null)
            {
                PopuldateNextRight(node.LeftChild, node);
            }
        }
    }
}
