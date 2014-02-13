using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _024_LargestRectangleHist
    {
        /*
        Given n non-negative integers representing the histogram's bar height where the width of each bar is 1, find the area of largest rectangle in the histogram.
        Above is a histogram where width of each bar is 1, given height = [2,1,5,6,2,3].
        The largest rectangle is shown in the shaded area, which has area = 10 unit.
 
        For example,
        Given height = [2,1,5,6,2,3],
        return 10.
        */
        /// <summary>
        /// set 2 pointer from begin and end of the array and calculate the area, and move pointer inside keep the largest area
        /// </summary>
        /// <param name="bars"></param>
        /// <returns></returns>
        public int FindLargestHistogram(int[] bars)
        {
            int left = 0;
            int right = bars.Length - 1;
            int maxArea = int.MinValue;
            int area = 0;
            while (left < right)
            {
                area = (right - left) * Math.Min(bars[left], bars[right]);
                maxArea = maxArea > area ? maxArea : area;
                if (bars[left] < bars[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }
    }
}
