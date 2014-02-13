using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter3_StacksAndQueues
{
    /*
     * Implement a MyQueue class which implements a queue using two stacks.
     */
    public class _03_05_MyQueue
    {
        public void Enqueue(int i)
        {
            if (s1.Count != 0)
            {
                s1.Push(i);
            }
            else
            {
                while (s2.Count != 0)
                {
                    s1.Push(s2.Pop());
                }
                s1.Push(i);
            }
        }

        public int Dequeue()
        {
            if (s2.Count != 0)
            {
                return s2.Pop();
            }
            else
            {
                while (s1.Count != 0)
                {
                    s2.Push(s1.Pop());
                }
                return s2.Pop();

            }
        }

        private Stack<int> s1 = new Stack<int>();
        private Stack<int> s2 = new Stack<int>();
    }
}
