using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_058_MaxIncrease
    {
        /*
         * 求一个数字数组里的最大连续数字的个数。3, 4, 4, 4, 2, 2, 3, 4 => return 3
         */
        public int FindMaxconsectiveIncrease(int[] input)
        {
            int maxLength = int.MinValue;
            int startIndex =0;
            int i = 1;
            while (i < input.Length)
            {
                if (input[i] - input[i - 1] == 1)
                {
                    i++;
                    continue;
                }
                else
                {
                    int tmp = i - startIndex;
                    maxLength = tmp > maxLength ? maxLength : tmp;
                }
            }
            return maxLength;
        }
    }
}
