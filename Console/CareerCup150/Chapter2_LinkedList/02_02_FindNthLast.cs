using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace CareerCup150.Chapt2_LinkedList
{
    public class _02_02_FindNthLast
    {
        /// <summary>
        /// Implement an algorithm to find the nth to last element of a singly linked list.
        ///  make sure if the length of list is n just return null;
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public LinkListNode FindNthNode(LinkListNode head, int n)
        {
            LinkListNode starter = head;
            LinkListNode follower = head;

            for (int i = 0; i < n; i++)
            {
                if (starter == null) return null;
                starter = starter.Next;
            }
            while (starter != null)
            {
                starter = starter.Next;
                follower = follower.Next;
            }
            return follower;
        }

    }
}
