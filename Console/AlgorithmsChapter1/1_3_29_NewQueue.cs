using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_3_29_NewQueue
    {
        /*
         * Write a Queue implementation that uses a circular linked list, which is the same as a linked list except 
         * that no links are null and the value of last.next is first whenever the list is not empty. Keep only one 
         * Node instance variable ( last).
         */

        private LinkListNode last;

        public _1_3_29_NewQueue()
        {
            last = null;
        }

        public void Enqueue(int input)
        {
            LinkListNode node = new LinkListNode() { Value = input };
            if (last == null) 
            {
                node.Next = node;
                last = node;
            }
            else
            {
                // I almost did a scan the wholoe list to find the position to enqueue.
                // stupid.
                node.Next = last.Next;
                last.Next = node;
                last =  node;
            }
        }

        public int Dequeue()
        {
            if (last == null) throw new Exception();
            if (last.Next == last)
            {
                int res = last.Value;
                // delete last;
                last = null;
                return res;
            }
            else
            {
                int res = last.Next.Value;
                LinkListNode tmp = last.Next;
                last.Next = last.Next.Next;
                //delete tmp;
                return res;
            }
        }

    }
}
