using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_051_To_75
{
    /*
     * Given a sorted linked list, delete all duplicates such that each element appear only once.
 
        For example,
         Given 1->1->2, return 1->2.
         Given 1->1->2->3->3, return 1->2->3. 

     */
    public class _058_RemoveDupFromSortedList
    {

        public LinkListNode RemoveDup(LinkListNode head)
        {
            LinkListNode newDummyHead = new LinkListNode();
            LinkListNode tmp = newDummyHead;

            tmp.Next = head;
            head = head.Next;

            while (head != null)
            {
                if (tmp.Value == head.Value)
                {
                    head = head.Next;

                }
                else
                {
                    tmp.Next = head;
                    tmp = tmp.Next;
                    head = head.Next;
                }

            }
            return newDummyHead.Next;
        }

        /*
         * Given a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list.
 
        For example,
         Given 1->2->3->3->4->4->5, return 1->2->5.
         Given 1->1->1->2->3, return 2->3. 
         */
        /// <summary>
        /// The code look really ugly, I need to improve it....
        /// this is kind of code which look simple (true for useing hashset)
        /// but it is hard to get it right at the first time.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public LinkListNode RemoveDupII(LinkListNode head)
        {
            LinkListNode dummyHead = new LinkListNode();
            dummyHead.Next = head;
            LinkListNode tmp = dummyHead;
            LinkListNode dupNode = null;
            while (tmp != null)
            {
                LinkListNode runner = tmp;
                if (dupNode == null)
                {
                    if (runner.Next != null && runner.Next.Next != null && runner.Next.Value == runner.Next.Next.Value)
                    {
                        dupNode = runner.Next;
                        runner = runner.Next;
                    }
                    else
                    {
                        dupNode = null;
                    }
                }
                if (dupNode != null)
                {
                    while (runner.Value == dupNode.Value && runner != null)
                    {
                        runner = runner.Next;
                    }
                    dupNode = null;
                    tmp.Next = runner;
                    continue;
                }
                else
                {
                    runner = runner.Next;
                }

                // only take node when dupNode is null.
                tmp.Next = runner;
                tmp = tmp.Next;
                dupNode = null;
            }
            return dummyHead.Next;
        }
    }
}
