using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter3_StacksAndQueues
{
    public class _03_06_SortStack
    {
        /*
         Write a program to sort a stack in ascending order. You should not make any assumptions about how 
         the stack is implemented. The following are the only functions that should be used to write this 
         program: push | pop | peek | isEmpty.
         */

        /// <summary>
        /// Sorting can be performed with one more stack. The idea is to pull an item from the original stack 
        /// and push it on the other stack. If pushing this item would violate the sort order of the new stack, 
        /// we need to remove enough items from it so that it’s possible to push the new item. Since the items 
        /// we removed are on the original stack, we’re back where we started. The algorithm is O(N^2) and 
        /// appears below.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public Stack<int> SortStack(Stack<int> s)
        {
            Stack<int> res = new Stack<int>();
            
            while (s.Count != 0)
            {
                int tmp = s.Pop();
                while (res.Count != 0 && tmp < res.Peek())
                {
                    s.Push(res.Pop());
                }
                res.Push(tmp);
            }
            return res;
        }
    }
}
