using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_3_32_Steque
    {
        /*
         * Steque. A stack-ended queue or steque is a data type that supports push , pop, and enqueue . 
         * Articulate an API for this ADT. Develop a linked-list-based implementation
         */
        private LinkListNode last;
        public void Push(int input)
        {
            LinkListNode node = new LinkListNode() { Value = input };
            if (last == null)
            {
                node.Next = node;
                last = node;
            }
            else
            {
                node.Next = last.Next;
                last.Next = node;
            }
        }

        public void Enqueue(int input)
        {
            this.Push(input);
            last = last.Next;
        }

        public int Pop()
        {
            if (last == null) throw new Exception();
            int res = last.Next.Value;
            LinkListNode node = last.Next;
            last.Next = last.Next.Next;
            // delete node;
            return res;
        }
    }
}
