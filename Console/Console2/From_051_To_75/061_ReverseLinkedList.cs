using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_051_To_75
{
    public class _061_ReverseLinkedList
    {
        /*
         * 
         * Reverse a linked list from position m to n. Do it in-place and in one-pass. 
            For example:
             Given 1->2->3->4->5->NULL, m = 2 and n = 4, 
            return 1->4->3->2->5->NULL. 
            Note:
             Given m, n satisfy the following condition:
             1 ≤ m ≤ n ≤ length of list. 
         */
        /// <summary>
        /// the method I used here is cut the linklist from m->n out and reverse it then hook it back to old linked list.
        /// </summary>
        /// <param name="head"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public LinkListNode ReverseLinkedListII(LinkListNode head, int m, int n)
        {
            LinkListNode dummyHead = new LinkListNode();
            dummyHead.Next = head;
            LinkListNode firstPartEnd = dummyHead;
            for(int i = 0;i<m-1;i++)
            {
                if (firstPartEnd == null)
                {
                    throw new Exception();
                }
                firstPartEnd = firstPartEnd.Next;
            }
            LinkListNode SecondStart = firstPartEnd.Next;
            LinkListNode SecondEnd = SecondStart;
            for (int i = 0; i < (n - m); i++)
            {
                if (SecondEnd == null)
                {
                    throw new Exception();
                }
                SecondEnd = SecondEnd.Next;
            }

            LinkListNode ThirdStart = SecondEnd.Next;
            SecondEnd.Next = null;
            SecondStart = ReverseLinkList(SecondStart);

            firstPartEnd.Next = SecondStart;

            while (SecondStart.Next != null)
            {
                SecondStart = SecondStart.Next;
            }
            SecondStart.Next = ThirdStart;
            return dummyHead.Next;
        }

        public LinkListNode ReverseLinkList(LinkListNode head)
        {
            LinkListNode newHead = null;
            LinkListNode tmp = null;

            while (head != null)
            {
                tmp = head;
                head = head.Next;
                tmp.Next = newHead;
                newHead = tmp;
            }
            return newHead;
        }
    }
}
