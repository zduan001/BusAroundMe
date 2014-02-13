using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_057_PrintOddEven
    {
        /*
         * 打印函数,奇数行完全打印,偶数行隔一个打印
         * 比如我有两行

            this is first line
            this is second line


            打印出来
            this is first line
            this second
         */
        /// <summary>
        /// assume separator is ' ' 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<string> PrintOddEven(List<string> input)
        {
            List<string> res = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                if(i%2 == 1)
                {
                    res.Add(input[i]);
                }
                if (i % 2 == 0)
                {
                    string[] tmp = input[i].Split(' ');
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j < tmp.Length; j++)
                    {
                        if (j % 2 == 0)
                        {
                            sb.Append(" " + tmp[j]);
                        }
                    }
                    res.Add(sb.ToString());
                }
            }
            return res;
        }
    }
}
