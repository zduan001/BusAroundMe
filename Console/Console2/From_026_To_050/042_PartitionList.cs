using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_026_To_050
{
    public class _042_PartitionList
    {
        /*
        Given a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.
 
        You should preserve the original relative order of the nodes in each of the two partitions.
 
        For example,
         Given 1->4->3->2->5->2 and x = 3,
         return 1->2->2->4->3->5. 

        */


        /// <summary>
        /// Can not tell what this question is testing. this is pretty straight forward solution.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public LinkListNode PartitionList(LinkListNode input, int value)
        {
            LinkListNode smallDummyHead = new LinkListNode();
            LinkListNode largeDummyHead = new LinkListNode();
            LinkListNode small = smallDummyHead;
            LinkListNode large = largeDummyHead;

            LinkListNode tmp = input;
            LinkListNode nexttmp = null;

            while (tmp != null)
            {
                nexttmp = tmp.Next;
                if (tmp.Value < value)
                {
                    small.Next = tmp;
                    small = small.Next;
                    small.Next = null;
                }
                else
                {
                    large.Next = tmp;
                    large = large.Next;
                    large.Next = null;
                }
                tmp = nexttmp;
            }

            small.Next = largeDummyHead.Next;
            return smallDummyHead.Next;

        }
    }
}
