using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyQuestions
{
    public class Week_2
    {
        /*
         * Clone a linked structure with two pointers per node. Suppose that you are given a reference to the first node of a linked structure where each node has two pointers: one pointer to the next node in the sequence (as in a standard singly-linked list) and one pointer to an arbitrary node. 
         * Design a linear-time algorithm to create a copy of the doubly-linked structure. You may modify the original linked structure, but you must end up with two copies of the original.
         */
        public Node Q_5_CloineLinkedList(Node head)
        {
            if (head == null) return null;

            Node dummyHeader = new Node();
            dummyHeader.next = head;
            Node tmp = head;
            while (tmp != null)
            {
                Node newNode = new Node() { item = tmp.item + "c", next = tmp.next };
                tmp.next = newNode;
                tmp = tmp.next.next;
            }

            tmp = head;
            while (tmp != null)
            {
                tmp.next.random = tmp.random.next;
                tmp = tmp.next.next;
            }

            Node res = new Node();
            Node runner1 = dummyHeader, runner2 = res;
            //bool original = true;
            tmp = head;
            while (tmp != null)
            {
                runner1.next = tmp;
                runner1 = tmp;
                runner2.next = tmp.next;
                runner2 = tmp.next;
                tmp = tmp.next.next;
            }

            return res.next;

        }

    }

    public  class Node
    {
        public String item;
        public Node next;
        public Node random;
    }

}
