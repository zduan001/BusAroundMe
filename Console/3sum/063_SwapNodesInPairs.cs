using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace console
{
    public class _063_SwapNodesInPairs
    {
        /// <summary>
        /// Given a linked list, swap every two adjacent nodes and return its head.
        /// For example,
        /// Given 1->2->3->4, you should return the list as 2->1->4->3.
        /// Your algorithm should use only constant space. You may not modify the values in the list, only nodes itself can be changed.
        /// 
        /// What if linked list has odd number of nodes.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public LinkListNode SwapNodeInPairs(LinkListNode head)
        {
            LinkListNode dummyHead = new LinkListNode();
            dummyHead.Next = head;
            LinkListNode tmp = dummyHead;
            while (tmp!= null)
            {
                if (tmp.Next == null)
                {
                    tmp = tmp.Next;
                }
                else if (tmp.Next.Next == null)
                {
                    tmp = tmp.Next.Next = null;
                }
                else
                {
                    LinkListNode newHead = tmp.Next.Next;
                    tmp.Next.Next = newHead.Next;
                    newHead.Next = tmp.Next;
                    tmp.Next = newHead;
                    tmp = tmp.Next.Next;
                }
            }
            return dummyHead.Next;
        }
    }
}
