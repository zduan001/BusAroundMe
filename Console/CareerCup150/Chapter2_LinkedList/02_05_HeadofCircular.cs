using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace CareerCup150.Chapt2_LinkedList
{
    public class _02_05_HeadofCircular
    {
        /*
            Given a circular linked list, implement an algorithm which returns node at the beginning of the loop.
            DEFINITION
            Circular linked list: A (corrupt) linked list in which a node’s next pointer points to an earlier node, 
            so as to make a loop in the linked list.
            EXAMPLE
            input: A -> B -> C -> D -> E -> C [the same C as earlier]
            output: C
         */
        /*
         * Solution:
         * Now, let’s suppose Fast Runner had a head start of k meters on an n step lap. When will they next meet? 
         * They will meet k meters before the start of the next lap. (Why? Fast Runner would have made k + 2(n - k) 
         * steps, including its head start, and Slow Runner would have made (n - k) steps. Both will be k steps before
         * the start of the loop.)
         * Now, going back to the problem, when Fast Runner (n2) and Slow Runner (n1) are moving around our circular 
         * linked list, n2 will have a head start on the loop when n1 enters. Specifically, it will have a head start 
         * of k, where k is the number of nodes before the loop. Since
         */
        public LinkListNode FindHeadOfCircular(LinkListNode head)
        {
            if (head == null) return null;
            if (head.Next == head) return head;
            // corner cases: null, one node ....

            LinkListNode fast = head.Next.Next;
            LinkListNode slow = head.Next; ;

            while (slow != fast)
            {
                if (fast.Next == null || fast.Next.Next == null)
                {
                    return null; // no circle...
                }
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            slow = head;
            while (slow != fast)
            {
                slow = slow.Next;
                fast = fast.Next;
            }
            return slow;
        }
    }
}
