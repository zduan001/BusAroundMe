using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_030_RememberPhoneNumber
    {
        /*
         * You are given a String number containing the digits of a phone number (the number
        of digits, n, can be any positive integer) . To help you memorize the number, you want
        to divide it into groups of contiguous digits. Each group must contain exactly 2 or 3 digits.
        There are three kinds of groups:
         Excellent: A group that contains only the same digits. For example, 000 or 77.
         Good: A group of 3 digits, 2 of which are the same. For example, 030, 229 or 166.
         Usual: A group in which all the digits are distinct. For example, 123 or 90.
        The quality of a group assignment is defined as 2 × (number of excellent groups) + (number
        of good groups), Divide the number into groups such that the quality is maximized.
         * Designan ecient algorithm to return the solution that maximizes the quality.
         */

        public int MaxQuality(int input)
        {
            List<int> tmp = new List<int>();

            while (input > 0)
            {
                tmp.Add(input % 10);
                input = input / 10;
            }

            int res = GetScore(tmp, 0, tmp.Count - 1);
            return res;
        }

        public int GetScore(List<int> input, int startIndex, int endIndex)
        {
            if(endIndex < startIndex)
            {
                return int.MinValue;
            }
            if (endIndex - startIndex == 1 || endIndex - startIndex == 2)
            {
                return Caculate(input, startIndex, endIndex);
            }
            else
            {
                int maxScore = int.MinValue;
                for(int i = startIndex+1;i< endIndex;i++)
                {
                    int tmp = GetScore(input, startIndex, i) + GetScore(input, i + 1, endIndex);
                    maxScore = maxScore > tmp ? maxScore : tmp;
                }
                return maxScore;
            }
        }


        public int Caculate(List<int> input, int startIndex, int endIndex)
        {
            if (endIndex - startIndex == 2)
            {
                if (input[startIndex] == input[startIndex + 1] && input[startIndex] == input[startIndex + 2])
                {
                    return 2;
                }
                else if (input[startIndex] == input[startIndex + 1] || input[startIndex] == input[startIndex + 2] || input[startIndex + 1] == input[startIndex + 2])
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (endIndex - startIndex == 1)
            {
                if (input[startIndex] == input[startIndex + 1])
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
