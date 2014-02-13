using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra
{
    public class LinkListNode
    {
        public int Value { get; set; }
        public LinkListNode Next { get; set; }

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
                newhead = tmp;
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

        /// <summary>
        /// Reverse a linked list from position m to n. Do it in-place and in one-pass.
        /// For example:
        /// Given 1->2->3->4->5->NULL, m = 2 and n = 4,
        /// return 1->4->3->2->5->NULL.
        /// Note:
        /// Given m, n satisfy the following condition:
        /// 1 ≤ m ≤ n ≤ length of list.
        /// REMEBER: 有关列表的题目要注意处理涉及到head Node的情况
        /// 代码分析：
        /// 做linkedlist的题，我总会在前面加个fakehead，这样基本上能应付head需要被操作的corner case。 返回fakehead.Next就完了。
        /// </summary>
        /// <param name="head"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static LinkListNode RevertPartialLinkList(LinkListNode head, int start, int end)
        {
            if (head == null) return null;
            if (start < 0 || end < 0) return null;
            if (start >= end) return head;
            
            LinkListNode dummyHead = new LinkListNode();
            dummyHead.Next = head;
            LinkListNode tmp = dummyHead;

            for (int i = 1; i < start; i++)
            {
                tmp = tmp.Next;
                if (tmp == null) return head; // linklist is shorter than start, return the original linklist.
            }

            LinkListNode oldHead = tmp.Next;
            LinkListNode workingHead = null;
            LinkListNode newHead = null;

            for (int i = start; i <= end; i++)
            {
                if (oldHead == null) break;

                workingHead = oldHead;
                oldHead = oldHead.Next;
                workingHead.Next = newHead;
                newHead = workingHead;
            }
            tmp.Next = newHead;

            //we need to connect oldhead if it is not null, aka not the end of the list.
            if (oldHead != null)
            {
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = oldHead;
            }
            return dummyHead.Next;
        }


        /// <summary>
        /// Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.
        /// If the number of nodes is not a multiple of k then left-out nodes in the end should remain as it is.
        /// You may not alter the values in the nodes, only nodes itself may be changed.
        /// Only constant memory is allowed.
        /// For example,
        /// Given this linked list: 1->2->3->4->5
        /// For k = 2, you should return: 2->1->4->3->5
        /// For k = 3, you should return: 3->2->1->4->5
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static LinkListNode ReverseNodeinKGroup(LinkListNode head, int k)
        {
            if (k <= 0) return head;

            LinkListNode dummyHead = new LinkListNode();
            dummyHead.Next = head;
            LinkListNode tmp = dummyHead;

            while (tmp.Next != null)
            {
                LinkListNode oldHead = tmp.Next;
                LinkListNode workingHead = null;
                LinkListNode newHead = null;

                for (int i = 0; i < k; i++)
                {
                    if (oldHead == null)
                    {
                        //reverse what I have reversed back.
                        while (newHead != null)
                        {
                            workingHead = newHead;
                            newHead = newHead.Next;
                            workingHead.Next = oldHead;
                            oldHead = workingHead;
                        }
                        newHead = oldHead;
                        oldHead = null;
                        break;
                    }
                    workingHead = oldHead;
                    oldHead = oldHead.Next;
                    workingHead.Next = newHead;
                    newHead = workingHead;
                }

                // move tmp to the node right before next round k. 
                tmp.Next = newHead;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }

                if (oldHead != null && tmp.Next == null)
                {
                    tmp.Next = oldHead;
                }
            }

            return dummyHead.Next;
        }

        #endregion

        #region remove dup


        /// <summary>
        /// Given a sorted linked list, delete all duplicates such that each element appear only once.
        /// For example,
        /// Given 1->1->2, return 1->2.
        /// Given 1->1->2->3->3, return 1->2->3.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static LinkListNode RemoveDups(LinkListNode input)
        {
            LinkListNode dummyHead = new LinkListNode();
            dummyHead.Next = input;
            LinkListNode tmp = dummyHead;
            LinkListNode nextPoint = tmp.Next;

            while (tmp != null)
            {
                while (nextPoint != null && tmp.Value == nextPoint.Value)
                {
                    nextPoint = nextPoint.Next;
                }
                tmp.Next = nextPoint;
                tmp = tmp.Next;
            }
            return dummyHead.Next;
        }


        /// <summary>
        /// Given a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list.
        /// For example,
        /// 
        /// Given 1->2->3->3->4->4->5, return 1->2->5.
        /// Given 1->1->1->2->3, return 2->3.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static LinkListNode RemoveDupsAll(LinkListNode input)
        {
            if (input == null || input.Next == null) return input;

            LinkListNode fakeHead = new LinkListNode();
            fakeHead.Next = input;
            LinkListNode tmp = fakeHead;
            LinkListNode end;
            
            while (tmp != null)
            {
                if (tmp.Next != null && tmp.Next.Next != null)
                {
                    if (tmp.Next.Value != tmp.Next.Next.Value)
                    {
                        tmp = tmp.Next;
                    }
                    else
                    {
                        end = tmp.Next.Next;
                        while (end != null && (end.Next == null || end.Value == end.Next.Value))
                        {
                            end = end.Next;
                        }

                        if (end == null)
                        {
                            tmp.Next = end;
                        }
                        else
                        {
                            tmp.Next = end.Next;
                        }
                        tmp = tmp.Next;
                    }
                }
                else
                {
                    break;
                }
            }
            return fakeHead.Next;
        }


        #endregion

        #region remove Nth Node from the end of list
        /// <summary>
        /// 
        /// Given a linked list, remove the nth node from the end of list and return its head.
        /// For example,
        /// Given linked list: 1->2->3->4->5, and n = 2.
        /// After removing the second node from the end, the linked list becomes 1->2->3->5.
        /// Note:
        /// Given n will always be valid.
        /// Try to do this in one pass.
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static LinkListNode RemoveNthNodeFromEnd(LinkListNode head, int n)
        {
            if (head == null) return null;
            if (n == 0) return head;
            LinkListNode dummyHead = new LinkListNode();
            dummyHead.Next = head;
            LinkListNode front = head;
            LinkListNode end = dummyHead;

            for (int i = 0; i < n; i++)
            {
                if (front == null)
                {
                    return head;
                }

                front = front.Next;
            }

            if (front == null) return head.Next; // Nth from end is the head;

            while (front != null)
            {
                end = end.Next;
                front = front.Next;
            }
            end.Next = end.Next.Next;

            return dummyHead.Next;
        }
        #endregion
    }
}
