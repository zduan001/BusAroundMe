using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_037_FindAinB
    {
        /*
         * 找到字符串A在字符串B中出现的次数，可以重复使用字母，比如A: aba B: ababa, 那么返回2.
         */
        public int FindAinB(string s1, string p)
        {
            if (s1.Length < p.Length) return 0;


            int res = 0;
            if (s1.StartsWith(p)) res ++;
            res = res + FindAinB(s1.Substring(1), p);
            return res;
        }
    }
}
