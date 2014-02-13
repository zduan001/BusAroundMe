using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftQuestions
{
    public class _003_SeparateArray
    {
        /*
         * 就是将数组里的负数排在数组的前面，正数排在数组的后面。但不改变原先负
            数和正数的排列顺序。
            例：input: -5，2，-3, 4，-8，-9, 1, 3，-10
            output: -5, -3, -8, -9, -10, 2, 4, 1, 3
         * http://www.mitbbs.com/article_t/JobHunting/32080539.html
         * I feel the trick of this kind in place swap array question 
         * if swap is not possible or hard, do mirror-then-mirror 
         */
        public void SeparateArray(int[] input)
        {
            int start = -1;
            int separaterIndex = -1;
            int end = -1;
            int i = 0;
            while (i< input.Length)
            {
                if (start == -1 && separaterIndex == -1 && end == -1)
                {
                    if (input[i] >= 0)
                    {
                        start = i;
                    }
                    i++;
                }
                else if (start > 0 && separaterIndex == -1 && end == -1)
                {
                    if (input[i] < 0)
                    {
                        separaterIndex = i;
                    }
                    i++;
                }
                else if (start > 0 && separaterIndex > 0 && end == -1)
                {
                    if (input[i] >= 0)
                    {
                        end = i - 1;
                    }
                    i++;
                }

                if (start >= 0 && separaterIndex >= 0 && end >= 0)
                {
                    start = Switch(input, start, end, separaterIndex);
                    separaterIndex = -1;
                    end = -1;
                }
            }
            end = input.Length-1;

            if (start >= 0 && separaterIndex >= 0 && end >= 0)
            {
                Switch(input, start, end, separaterIndex);
            }
        }

        public int Switch(int[] input, int start, int end, int mid)
        {
            int left = start;
            int right = end;
            Swap(input, left, right);
            int separator = end - (mid - start);
            left = start;
            right = separator;
            Swap(input, left, right);
            left = separator + 1;
            right = end;
            Swap(input, left, right);
            return separator + 1;
        }

        private static void Swap(int[] input, int left, int right)
        {
            while (left < right)
            {
                int tmp = input[left];
                input[left] = input[right];
                input[right] = tmp;
                left++;
                right--;
            }
        }
    }
}
