using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapt1_ArraysAndStrings
{
    public class _01_03_RemoveDupFromString
    {
        /*
         * Design an algorithm and write code to remove the duplicate characters in a string 
         * without using any additional buffer. NOTE: One or two additional variables are fine. 
         * An extra copy of the array is not.
        FOLLOW UP
        Write the test cases for this method.
         */
        /// <summary>
        /// if no buffer, I can thing of brutal forece....  but.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string RemoveDup(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return string.Empty;

            char[] chars = s.ToArray();
            int tail = 0;
            int runner = 0;
            int maxLength = chars.Length-1;
            for (int i = 0; i <= maxLength; i++)
            {
                tail = i;
                runner = i;
                while (runner <= maxLength)
                {
                    if(chars[i] == chars[runner])
                    {
                        runner++;
                    }
                    else
                    {
                        chars[tail+1] = chars[runner];
                        tail ++; 
                        runner ++;
                    }
                }
                maxLength = tail;
            }

            StringBuilder sb = new StringBuilder();
            for(int i = 0;i<= maxLength;i++)
            {
                sb.Append(chars[i]);
            }
            return sb.ToString();
        }
    }
}
