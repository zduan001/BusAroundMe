using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _007_ContainerWithMostWater
    {
        /// <summary>
        /// Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). 
        /// n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). 
        /// Find two lines, which together with x-axis forms a container, such that the container contains 
        /// the most water.
        /// </summary>
        /// <param name="input"></param>
        public List<int> FindLargestContainer(int[] input)
        {
            int a = 0;
            int b = input.Length - 1;
            int maxCapacity = 0;
            int maxLeft = -1;
            int maxRight = -1;
            int leftHeight = 0;
            int rightHeight = 0;

            while (a < b)
            {
                leftHeight = input[a];
                rightHeight = input[b];
                int capacity = Math.Min(input[a], input[b]) * (b - a);
                if (maxCapacity < capacity)
                {
                    maxCapacity = capacity;
                    maxLeft = a;
                    maxRight = b;
                }

                if (leftHeight > rightHeight)
                {
                    while (input[--b] < rightHeight) ;
                }
                else
                {
                    while (input[++a] < leftHeight) ;
                }
            }

            List<int> res = new List<int>() { maxCapacity, maxLeft, maxRight };
            return res;
        }

        /// <summary>
        /// Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). 
        /// n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). 
        /// Find two lines, which together with x-axis forms a container, such that the container contains 
        /// the most water. this methos use brutal force to solve the problem.
        /// </summary>
        /// <param name="input">the input array make the conainer</param>
        public List<int> FindLargestContainerBrutal(int[] input)
        {
            int maxCapacity = 0;
            int maxLeft = 0;
            int maxRight = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (maxCapacity < Math.Min(input[i], input[j]) * (j - i))
                    {
                        maxCapacity = Math.Min(input[i], input[j]) * (j - i);
                        maxLeft = i;
                        maxRight = j;
                    }
                }
            }

            List<int> res = new List<int>() { maxCapacity, maxLeft, maxRight };
            return res;
        }
    }
}
