using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _011_CountAndSay
    {
        /*
            The count-and-say sequence is the sequence of integers beginning as follows:
            1, 11, 21, 1211, 111221, ...
 
            1 is read off as "one 1" or 11.
            11 is read off as "two 1s" or 21.
            21 is read off as "one 2, then one 1" or 1211.
 
            Given an integer n, generate the nth sequence.
 
            Note: The sequence of integers will be represented as a string.
         */
        /// <summary>
        /// the requirement of the question is really hard to understand.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string CountAndSay(int n)
        {
            StringBuilder sb = new StringBuilder();
            string tmp = "1";
            
            for (int i = 2; i <= n; i++)
            {
                int count = 1;
                int j = 0;
                while (j < tmp.Length)
                {
                    if(j == tmp.Length-1 || tmp[j] != tmp[j + 1])
                    {
                        sb.Append(count.ToString() + tmp[j]);
                        j++; 
                        count = 1;
                    }
                    else
                    {
                        j++;
                        count++;
                    }
                }
                tmp = sb.ToString();
                sb.Clear();
            }
            return tmp;
        }
    }
}
