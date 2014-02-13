using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace console
{
    public class _056_RotateList
    {    
        
        /*
         * 
         * 
         * Bug free Bug Free. For such a simple code, you need bug free.
         * 
         *
         */

        /// <summary>
        /// Given a list, rotate the list to the right by k places, where k is non-negative.
        /// For example:
        /// Given 1->2->3->4->5->NULL and k = 2,
        /// return 4->5->1->2->3->NULL.

        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public LinkListNode RotateLinkList(LinkListNode head, int k)
        {
            if (head == null || head.Next == null || k==0) return head;
            if (k < 0) throw new ArgumentException("K has to be a non negative");
            LinkListNode dummyHead = new LinkListNode();
            dummyHead.Next = head;
            LinkListNode front = dummyHead;
            LinkListNode back = dummyHead;

            for (int i = 0; i < k; i++)
            {
                front = front.Next;
                if (front == null)
                {
                    front = head;
                }
            }
            
            while(front.Next != null)
            {
                front = front.Next;
                back = back.Next;
            }

            LinkListNode newHead = back.Next;
            back.Next = null;
            front.Next = head;

            return newHead;
        }
    }
}
