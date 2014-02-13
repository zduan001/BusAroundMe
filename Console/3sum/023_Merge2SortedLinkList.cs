using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace console
{
    public class _023_Merge2SortedLinkList
    {
        /// <summary>
        /// Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.
        /// </summary>
        /// <param name="l1">sorted list 1</param>
        /// <param name="l2">sorted list 2</param>
        /// <returns>new list</returns>
        public LinkListNode Merger(LinkListNode l1, LinkListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            LinkListNode head = new LinkListNode();
            LinkListNode tmp;
            LinkListNode cur = head;
            while (l1 != null && l2 != null)
            {
                if (l1.Value < l2.Value)
                {
                    tmp = l1;
                    l1 = l1.Next;
                }
                else
                {
                    tmp = l2;
                    l2 = l2.Next;
                }
                cur.Next = tmp;
                cur = cur.Next;
            }
            if (l1 != null)
            {
                cur.Next = l1;
            }
            if (l2 != null)
            {
                cur.Next = l2;
            }
            return head.Next;
        }

        /// <summary>
        /// Merge k sorted linked lists and return it as one sorted list. Analyze and describe its complexity.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public LinkListNode MergerKSortedList(List<LinkListNode> input)
        {
            LinkListNode head = new LinkListNode();
            LinkListNode cur = head;
            int tmp = int.MaxValue;
            int index = 0;

            while (index > -1)
            {
                tmp = int.MaxValue;
                index = -1;

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] != null && input[i].Value < tmp)
                    {
                        index = i;
                        tmp = input[i].Value;
                    }
                }
                if (index != -1)
                {
                    LinkListNode node = input[index];
                    input[index] = input[index].Next;
                    cur.Next = node;
                    cur = cur.Next;
                }
            }

            return head.Next;
        }
    }
}
