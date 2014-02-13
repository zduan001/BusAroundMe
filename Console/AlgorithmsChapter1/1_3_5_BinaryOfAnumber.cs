using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_3_5_BinaryOfAnumber
    {
        /*
         * What does the following code fragment print when N is 50 ? Give a high-level 
         * description of what it does when presented with a positive integer N . 
         */
        /// <summary>
        /// this method print out the binary format of the nubmer n.
        /// </summary>
        /// <param name="n"></param>
        public void WhatDoesthisMethodDo(int n)
        {
            Stack<int> stack = new Stack<int>(); 
            while (n > 0) 
            { 
                stack.Push(n % 2);
                n = n / 2; 
            }

            while (stack.Count > 0)
            {
                System.Console.Write(stack.Pop());
            }
        }
    }
}
