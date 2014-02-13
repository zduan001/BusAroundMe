using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_026_To_050
{
    /*
     * Merge k sorted linked lists and return it as one sorted list. Analyze and describe its complexity.
     */
    public class _034_MergeKSortedList
    {
        public LinkListNode MergeLinkedList(List<LinkListNode> input)
        {
            LinkListNode dummyHead = new LinkListNode();
            LinkListNode tmp = dummyHead;

            // Assume: this is building Min Heap base on the first node value of each linkedlist. 
            // Sort input.
            while (input.Count != 0)
            {
                int value = GetTheLeastValue(input);
                LinkListNode newNode = new LinkListNode();
                newNode.Value = value;
                tmp.Next = newNode;
                tmp = tmp.Next;
            }

            return dummyHead.Next;
        }

        /// <summary>
        /// this method I scanned through the list to find the min value, this take O(n)
        /// But I actual can create a min heap to take the min value and update the heap
        /// this will take O(lg n) time.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private int GetTheLeastValue(List<LinkListNode> input)
        {
            int res = int.MaxValue;
            int index = -1;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].Value < res)
                {
                    res = input[i].Value;
                    index = i;
                }
            }
            if (index != -1)
            {
                input[index] = input[index].Next;
                if (input[index] == null)
                {
                    input.RemoveAt(index);
                }
            }
            return res;
        }
    }
}
