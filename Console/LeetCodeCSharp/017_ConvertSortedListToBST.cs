using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _017_ConvertSortedListToBST
    {
        /*
         * http://leetcode.com/onlinejudge#question_109
         */
        public TreeNode Convert(LinkListNode head)
        {
            if (head == null)
            {
                return null;
            }
            if (head.Next == null)
            {
                return new TreeNode(head.Value);
            }

            LinkListNode faster = head.Next;
            LinkListNode slower = head;
            while (faster.Next != null && faster.Next.Next != null)
            {
                faster = faster.Next.Next;
                slower = slower.Next;
            }

            TreeNode root = new TreeNode(slower.Next.Value);
            LinkListNode right = slower.Next.Next;
            slower.Next = null;

            root.LeftChild = Convert(head);
            root.RightChild = Convert(right);
            return root;

        }
    }
}
