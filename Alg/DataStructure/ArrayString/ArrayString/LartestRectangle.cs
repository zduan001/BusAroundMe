using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class LartestRectangle
    {
        /*http://tianrunhe.wordpress.com/2012/07/26/largest-rectangle-in-histogram/
         * Given n non-negative integers representing the histogram’s bar height where the width of each bar is 1, find the area of largest rectangle in the histogram.
         */
        public int FindMaxRectangleInAHistgram(int[] input)
        {
            if (input == null || input.Length == 0)
            {
                return -1;
            }

            int max = 0;
            Stack<int> s = new Stack<int>();
            s.Push(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] >= s.Peek())
                {
                    s.Push(input[i]);
                }
                else
                {
                    int count = 0;
                    while (!(s.Count == 0) && input[i] < s.Peek())
                    {
                        int height = s.Pop();
                        count++;
                        max = max > height * (count) ? max : height * (count);
                    }

                    while (count >= 0) // need to push one more than count. because the lastest element.
                    {
                        s.Push(input[i]);
                        count--;
                    }
                }
            }

            int a = 0;
            while (!(s.Count == 0))
            {
                int height = s.Pop();
                a++;
                max = max > height * a ? max : height * a;
            }

            return max;
        }

        public int FindMaxRectangleInAHistgramII(int[] input)
        {
            if (input == null || input.Length == 0) return -1;

            int maxArea = 0;
            Stack<int> s = new Stack<int>();
            int i = 0;
            while (i < input.Length)
            {
                if (s.Count == 0 || input[i] >= input[s.Peek()])
                {
                    s.Push(i++);
                }
                else
                {
                    int h = s.Pop();
                    int tmpArea = input[h] * (s.Count == 0 ? i : i - s.Peek() - 1);
                    maxArea = maxArea > tmpArea ? maxArea : tmpArea;
                }
            }

            while (s.Count != 0)
            {
                int h = s.Pop();
                int tmpArea = input[h] * (s.Count == 0 ? i : i - s.Peek() - 1);
                maxArea = maxArea > tmpArea ? maxArea : tmpArea;
            }

            return maxArea;
        }
    }
}
