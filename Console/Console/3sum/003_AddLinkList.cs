using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace console
{
    public class _003_AddLinkList
    {

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
