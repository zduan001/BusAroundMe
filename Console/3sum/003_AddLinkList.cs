using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace console
{
    public class _003_AddLinkList
    {
        /*
            You have two numbers represented by a linked list, where each node contains a single digit. The digits are stored in reverse order, such that the 1’s digit is at the head of the list. Write a function that adds the two numbers and returns the sum as a linked list.
            EXAMPLE
            Input: (3 -> 1 -> 5) + (5 -> 9 -> 2)
            Output: 8 -> 0 -> 8
         */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public LinkListNode AddLinkList(LinkListNode list1, LinkListNode list2)
        {
            LinkListNode newHead = new LinkListNode();
            LinkListNode tmp = newHead;
            int carry = 0;
            int result = 0;

            while (list1 != null && list2 != null)
            {
                result = (list1.Value + list2.Value) % 10;
                
                LinkListNode node = new LinkListNode() { Value = result + carry, Next = null };
                tmp.Next = node;
                tmp = node;

                carry = (list1.Value + list2.Value) / 10;
                list1 = list1.Next;
                list2 = list2.Next;
            }

            if (list1 != null)
            {
                list1.Value = list1.Value + carry;
                tmp.Next = list1;
            }
            else if (list2 != null)
            {
                list2.Value = list2.Value + carry;
                tmp.Next = list2;
            }
            else if (carry != 0)
            {
                LinkListNode node = new LinkListNode() { Value = carry, Next = null };
                tmp.Next = node;
            }

            return newHead.Next;
        }
    }
}
