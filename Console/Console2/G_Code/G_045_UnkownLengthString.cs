using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_045_UnkownLengthString
    {
        /*
         * 一个排序好的不知道长度的数组，在其中search 一个给定值
         * http://www.mitbbs.com/article_t/JobHunting/32197465.html
         */
        /// <summary>
        /// since I do not know the length, I have to try to probe.
        /// I expand the length by 2 every time. if out of range shrink 
        /// the length by 2 everytime until the step/length less than 1.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Search(int[] input, int value)
        {
            int step = 1;
            int currentIndex = 0;

            while (step > 1)
            {
                try
                {
                    int tmp = input[currentIndex + step];

                    currentIndex = currentIndex + step;
                    step *= 2;

                }
                catch (Exception e)
                {
                    step /= 2;

                }
            }

            int left = 0;
            int right = currentIndex;
            while (left <= right)
            {
                int mid = left + right;
                if (input[mid] == value)
                {
                    return mid;
                }
                else if (value > input[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;

        }
    }
}
