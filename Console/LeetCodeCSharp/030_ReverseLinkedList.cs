using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _030_ReverseLinkedList
    {
        /*
         * http://leetcode.com/onlinejudge#question_92
         * Reverse a linked list from position m to n. Do it in-place and in one-pass.

            For example:
             Given 1->2->3->4->5->NULL, m = 2 and n = 4,

            return 1->4->3->2->5->NULL.

            Note:
             Given m, n satisfy the following condition:
             1 < m < n < length of list.
         */
        public void RevertLinkedList(LinkListNode header, int m, int n)
        {
            LinkListNode tmp = header;
            LinkListNode firstEnd;
            LinkListNode secondStart;
            LinkListNode secondEnd;
            LinkListNode thirdStart;

            for (int i = 1; i < m-1; i++)
            {
                tmp = tmp.Next;
            }

            firstEnd = tmp;

            tmp = tmp.Next;
            secondStart = tmp;
            for (int i = m; i < n; i++)
            {
                tmp = tmp.Next;
            }
            secondEnd = tmp;
            tmp = tmp.Next;
            thirdStart = tmp;
            secondEnd.Next = null;
            secondEnd = secondStart;

            LinkListNode newHead = null;
            tmp = secondStart;
            while (secondStart != null)
            {
                secondStart = tmp.Next;
                tmp.Next = newHead;
                newHead = tmp;
                tmp = secondStart;
            }

            firstEnd.Next = newHead;
            secondEnd.Next = thirdStart;
        }
    }
}
