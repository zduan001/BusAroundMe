using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _043_ReverseInteger
    {

        /// <summary>
        /// Reverse digits of an integer.
        /// Example1: x = 123, return 321
        /// Example2: x = -123, return -321
        /// Discuss: 1.If the integer's last digit is 0, what should the output be? ie, cases such as 10, 100.
        ///  　　　　 2.Reversed integer overflow.
        ///  题目已经说了要跟面试官讨论一下两个问题，10， 100 应该返回什么，我觉得肯定是返回 1 的。 
        ///  如果整数反转后overflow怎么办，这个能提出来应该能展示你的细心。上面的代码没有处理这种情况的，
        ///  默认反转后不会overflow的。
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int ReverseInteger(int input)
        {
            bool isNgative = input<0? true: false;
            if (isNgative)
            {
                input = Math.Abs(input);
            }

            //Try to find the length of th integer.
            int length = 0;
            while (input >= Math.Pow(10, length))
            {
                length++;
            }
            int[] digits = new int[length];

            for (int i = 0; i < length; i++)
            {
                digits[i] = input % 10;
                input = input / 10;
            }

            for (int i = 0; i < length / 2; i++)
            {
                int tmp = digits[i];
                digits[i] = digits[length - i - 1];
                digits[length - i - 1] = tmp;
            }

            // ToDo: check overflow.

            int res = 0;
            for (int i = 0; i < length; i++)
            {
                res +=(int)( digits[i] * Math.Pow(10, i));
            }

            if (isNgative) res = -res;

            return res;
        }
    }
}
