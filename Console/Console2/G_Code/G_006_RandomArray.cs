using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_006_RandomArray
    {
        /*
         * 第一个是给个数组，打乱了，比如 
 
            索引 0 1 2 3 4 
            值   3 2 1 4 0 
            数组的值是下次跳的索引位置，这样的话数组有环，比如 0 -> 3 -> 4 -> 0 1 -> 2  
            -> 1， 求最长环的长度. 

         */
        public int LongestCircle(int[] input)
        {
            int longestLength = int.MinValue;
            for (int i = 0; i < input.Length; i++)
            {
                int steps = 1;
                int tmp = input[i];
                while (tmp != i)
                {
                    steps++;
                    tmp = input[tmp];
                }
                longestLength = longestLength > steps ? longestLength : steps;
            }
            return longestLength;
        }
    }
}
