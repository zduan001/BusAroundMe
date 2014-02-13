using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleQuestions
{
    public class _004_dqueueUser
    {
        /*
         * how to design a queue, in addition to insert() , delete() , also has a function 
         * min() which returns the minumum element? Can you do all functions in O(1) time?
         */
        private Deque<int> queue;
        private Deque<int> minQueue;

        public _004_dqueueUser()
        {
            queue = new Deque<int>();
            minQueue = new Deque<int>();
        }

        public void Enqueue(int value)
        {
            while (!minQueue.IsEmpty() && minQueue.PeekBack() > value)
            {
                minQueue.PopBack();
            }

            minQueue.PushBack(value);
            queue.PushBack(value);
        }

        public int Dequeue()
        {
            if (queue.IsEmpty()) throw new Exception();
            int res = queue.PopFront();
            if (res == minQueue.PeekFront())
            {
                minQueue.PopFront();
            }
            return res;
        }

        public int Min()
        {
            if (minQueue.IsEmpty()) throw new Exception();
            return minQueue.PeekFront();
        }
    }
}
