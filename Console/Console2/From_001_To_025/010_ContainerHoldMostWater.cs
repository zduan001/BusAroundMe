using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _010_ContainerHoldMostWater
    {
        /*
         * Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). 
         * n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two 
         * lines, which together with x-axis forms a container, such that the container contains the most water
         * Note: I think this question must be a mistaken understand the rain water one.
         */
        public int FindContainerContainsMostWater(int[] height)
        {
            int a = 0;
            int b = height.Length - 1;
            int max = int.MinValue;

            while(a<b)
            {
                int h = Math.Min(height[a], height[b]);
                int vol = h * (b - a);
                max = max > vol ? max : vol;

                if (height[a] <= height[b])
                {
                    while (height[++a] > height[a]) ;
                }
                else
                {
                    while (height[--b] > height[b]) ;
                }
            }

            return max;
        }
    }
}
