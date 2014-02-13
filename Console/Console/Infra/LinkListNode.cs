using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra
{
    public class LinkListNode
    {
        public int Value { get; set; }
        public LinkListNode Next{ get; set; }

        /// <summary>
        /// Create a link list from an array.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static LinkListNode CreateLinkList(int[] array)
        {
            LinkListNode head = new LinkListNode();
            LinkListNode tmp = head;
            for (int i = 0; i < array.Length; i++)
            {
                LinkListNode node = new LinkListNode() { Value = array[i], Next = null };
                tmp.Next = node;
                tmp = node;
            }
            return head.Next;
        }

        #region reverse linklist

        /// <summary>
        /// Reverse a linked list using iterative.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static LinkListNode ReverseLinkListIterative(LinkListNode head)
        {
            if (head == null) return null;
            LinkListNode newhead, tmp;

            newhead = head;
            tmp = newhead;
            head = head.Next;

            while (head != null)
            {
                tmp = head;
                head = head.Next;
                tmp.Next = newhead;
                newhead= tmp;
            }

            return newhead;
        }


        /// <summary>
        /// Reverse a linkl like using reursve, 
        /// If I can pass in another ref to the last node. I do not have to travel through 
        /// the new sub list everyting to add the head back to the end.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static LinkListNode RevertLinkListRecursive(LinkListNode head)
        {
            if (head == null) return null;
            if (head.Next == null) return head;

            LinkListNode newHead = RevertLinkListRecursive(head.Next);

            if (newHead != null)
            {
                LinkListNode tmp = newHead;
                while (tmp.Next != null) tmp = tmp.Next;
                tmp.Next = head;
                head.Next = null;
            }
            return newHead;
        }
        #endregion
    }
}
