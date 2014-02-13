using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_076_To_100
{
    public class _081_SwapNodesInPair
    {
        /*
        Given a linked list, swap every two adjacent nodes and return its head. 
        For example,
         Given 1->2->3->4, you should return the list as 2->1->4->3. 
        Your algorithm should use only constant space. You may not modify the values in the list, only nodes itself can be changed.
         */
        public LinkListNode SwapInPair(LinkListNode head)
        {
            LinkListNode dummyHead = new LinkListNode();
            dummyHead.Next = head;
            LinkListNode tmp = dummyHead;
            
            while (tmp.Next != null && tmp.Next.Next != null)
            {
                LinkListNode l1 = tmp.Next;
                LinkListNode l2 = tmp.Next.Next;
                l1.Next = l2.Next;
                tmp.Next = l2;
                l2.Next = l1;
                tmp = tmp.Next.Next;
            }

            return dummyHead.Next;
        }
    }
}
