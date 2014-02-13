using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_051_To_75
{
    public class _065_RotateList
    {
        /*
        Given a list, rotate the list to the right by k places, where k is non-negative.
        For example:
         Given 1->2->3->4->5->NULL and k = 2,
         return 4->5->1->2->3->NULL.
         */
        public LinkListNode RotateRight(LinkListNode head, int k)
        {
            LinkListNode faster = head;
            LinkListNode slower = head;
            for (int i = 0; i < k; i++)
            {
                //take care if the k > linkedlist length.
                if (faster == null)
                {
                    faster = head;
                }
                faster = faster.Next;
            }


            if (faster == null) return head;

            while (faster.Next != null)
            {
                faster = faster.Next;
                slower = slower.Next;
            }

            LinkListNode newHead = slower.Next;
            slower.Next = null;
            faster.Next = head;
            return newHead;
        }
    }
}
