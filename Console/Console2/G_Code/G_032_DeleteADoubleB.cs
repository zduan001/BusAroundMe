using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_032_DeleteADoubleB
    {
        /*
         * 处理一个字符串，删除里面所有的A，double所有的B例子，输入CAABD, 输出是CBBD
         */
        public string DeleteADoubleB(string input, char del, char dou)
        {
            Queue<char> q = new Queue<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == del)
                {
                    continue;
                }
                if (input[i] ==dou)
                {
                    q.Enqueue(input[i]);
                }
                q.Enqueue(input[i]);
            }
            StringBuilder sb = new StringBuilder();
            while (q.Count != 0)
            {
                sb.Append(q.Dequeue());
            }
            return sb.ToString();
        }

        /// <summary>
        /// In place space O(1). make sure I have to do it in 2 passes. 
        /// other wise the char array willl be messed up.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="del"></param>
        /// <param name="dou"></param>
        /// <returns></returns>
        public string DeleteADoubleBII(string input, char del, char dou)
        {
            char[] tmp = input.ToCharArray();
            int tail = 0;
            int runner = 0;
            int countofDou = 0;
            while (runner < tmp.Length)
            {
                if (input[runner] == dou) countofDou++;
                if (input[runner] == del)
                {
                    runner++;
                }
                else
                {
                    if (tail != runner)
                    {
                        tmp[tail] = tmp[runner];
                    }
                    runner++;
                    tail++;
                }
            }
            // get the last index of compact string.
            tail--;
            // get the length of string after expand.
            int longtail = tail + countofDou;
            int end = longtail;
            while (longtail > tail)
            {
                tmp[longtail] = tmp[tail];
                if (tmp[longtail] == dou)
                {
                    longtail--;
                    tmp[longtail] = tmp[tail];
                }
                longtail--;
                tail--;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= end; i++)
            {
                sb.Append(tmp[i]);
            }
            return sb.ToString();
        }
    }
}
