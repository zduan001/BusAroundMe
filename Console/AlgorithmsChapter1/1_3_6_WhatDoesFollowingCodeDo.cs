using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_3_6_WhatDoesFollowingCodeDo
    {
        /*
         * What does the following code fragment do to the queue q?
         */
        /// <summary>
        /// this just revers the queue.
        /// </summary>
        /// <param name="q"></param>
        public void Reverse(Queue<int> q)
        {
            Stack<int> s = new Stack<int>();
            while(q.Count >0)
            {
                s.Push(q.Dequeue());
            }
            while(s.Count >0)
            {
                q.Enqueue(s.Pop());
            }
        }
    }
}
