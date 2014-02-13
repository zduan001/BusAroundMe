using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace CareerCup150.Chapt2_LinkedList
{
    public class _02_01_RemoveDup
    {
        /*
         Write code to remove duplicates from an unsorted linked list.
        FOLLOW UP
        How would you solve this problem if a temporary buffer is not allowed?
         */
        public LinkListNode RemoveDup(LinkListNode head)
        {
            LinkListNode dummyHead = new LinkListNode();
            dummyHead.Next = head;

            LinkListNode tmp = dummyHead;
            HashSet<int> nodes = new HashSet<int>();

            while (tmp.Next != null)
            {
                if (nodes.Contains(tmp.Next.Value))
                {
                    tmp.Next = tmp.Next.Next;
                }
                else
                {
                    nodes.Add(tmp.Next.Value);
                    tmp = tmp.Next;
                }
            }

            return dummyHead.Next;
        }

        /// <summary>
        /// Same method as last one except no hashtable used.
        /// basically sort the linklist, if a dup value seen just ignore.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public LinkListNode RemoveDupNoHashTable(LinkListNode head)
        {
            LinkListNode dummyHead = new LinkListNode();
            dummyHead.Next = head;

            LinkListNode newHead = new LinkListNode();

            LinkListNode tmp = head.Next;
            while (tmp != null)
            {
                LinkListNode traveler = newHead;
                LinkListNode holder = tmp.Next;
                while (traveler.Next != null)
                {
                    if (tmp.Value < traveler.Next.Value)
                    {
                        tmp.Next = traveler.Next;
                        traveler.Next = tmp;
                        break;
                    }
                    else if (tmp.Value == traveler.Next.Value)
                    {
                        break;
                    }
                    else
                    {
                        traveler = traveler.Next;
                    }
                }
                tmp = holder;
            }
            return newHead.Next;
        }
    }
}
