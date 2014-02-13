using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.G_Code
{
    public class G_033_NewQueue
    {
        /*
         * how to design a queue, in addition to insert() , delete() , also has a function min() 
         * which returns the minumum element? Can you do all functions in O(1) time?
         */
        /*
         * Add a link list to keep track the current min.
         * 1. Enqueue, 
         *      a) if the value enqueue is smaller than the first node of the linklist, discard original linklist. create a new linklist with head's 
         *         value equal to the enqueued value.
         *      b) if the value enqueue is larger than the first node of linklist. try to find the first node in the linklist is larger than the value, 
         *         insert it infront of it, or if reached end of the linklist append it.
         * 2. Dequeue
         *      a) if the dequeued value equal to the head of linklist. remove the head of linklist.
         *      b) if the dequeued value not equal the head of linklist do nothing.
         * 3. Min
         *      just return the head of the linklist, as long as there is element in the queue, linklist should not be null.
         */

        private Queue<int> localQueue;
        private LinkListNode localMin;

        public G_033_NewQueue()
        {
            localQueue = new Queue<int>();
        }

        public void Enqueue(int input)
        {
            localQueue.Enqueue(input);
            if (localMin == null)
            {
                localMin = new LinkListNode() { Value = input };
            }
            else
            {
                if (input < localMin.Value)
                {
                    localMin = new LinkListNode() { Value = input };
                }
                else
                {
                    LinkListNode tmp = localMin;
                    while (tmp.Next != null && tmp.Next.Value < input)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Next = new LinkListNode() { Value = input };
                }
            }

        }

        public int Dnqueue()
        {
            // check if local Queue is empty .....
            int res = localQueue.Dequeue();
            if (res == localMin.Value)
            {
                localMin = localMin.Next;
            }
            return res;

        }

        public int Min()
        {
            // check if locastack is empty......
            if (localMin != null)
                return localMin.Value;
            else
            {
                throw new Exception();
            }
        }

    }


}
