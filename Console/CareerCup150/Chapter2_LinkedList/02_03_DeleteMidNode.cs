using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace CareerCup150.Chapt2_LinkedList
{
    public class _02_03_DeleteMidNode
    {
        /*
         Implement an algorithm to delete a node in the middle of a single linked list, given only access to that node.
            EXAMPLE
            Input: the node ‘c’ from the linked list a->b->c->d->e
            Result: nothing is returned, but the new linked list looks like a->b->d->e
         */
        /// <summary>
        /// The trick is, this is not a real "delete", it just copy the next node's value to the
        /// node and skip next node. so for the list, it look like the node (which is passed in) 
        /// is delete.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool DeleteMiddleNode(LinkListNode node)
        {
            if (node == null || node.Next == null)
            {
                return false;
            }

            node.Value = node.Next.Value;
            node.Next = node.Next.Next;
            return true;
        }
    }
}
