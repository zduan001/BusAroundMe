using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _060_RomanToInteger
    {
        /// <summary>
        /// Given a roman numeral, convert it to an integer.
        /// Input is guaranteed to be within the range from 1 to 3999.
        ///  4             map.Add('I', 1);
        ///  5             map.Add('V', 5);
        ///  6             map.Add('X', 10);
        ///  7             map.Add('L', 50);
        ///  8             map.Add('C', 100);
        ///  9             map.Add('D', 500);
        ///  10            map.Add('M', 1000);
        /// 代码分析：
 
　        /*
        * 抄来之码， 第一次写的另外一个做法，把，1～9， 10～90， 100～900，1000做了一个look up table，然后分别把one, 
        * ten, hundred, thousand,位独立开，然后再look up table中找出，乘以相应的倍数 += 到 ret 中。Look up table 对于 
        * Integer to Roman 是非常方便的，但是在Roman to Integer中反而有点罗嗦。 所以抄来上面的代码。
        * 观察到只有 4 和 9 做减法 （4 = IV = 5 - 1， 9 = IX = 10 - 1), 所以有了上面RomantoInteger2Sign 函数。
        * 例如 “CDLXIV” = -100 + 500 + 50 + 10 - 1 +5 = 464
        * 代码分析：
        * 抄来之码， 第一次写的另外一个做法，把，1～9， 10～90， 100～900，1000做了一个look up table，然后分别把one, 
        * ten, hundred, thousand,位独立开，然后再look up table中找出，乘以相应的倍数 += 到 ret 中。Look up table 对于 
        * Integer to Roman 是非常方便的，但是在Roman to Integer中反而有点罗嗦。 所以抄来上面的代码。
        * 观察到只有 4 和 9 做减法 （4 = IV = 5 - 1， 9 = IX = 10 - 1), 所以有了上面RomantoInteger2Sign 函数。
        * 例如 “CDLXIV” = -100 + 500 + 50 + 10 - 1 +5 = 464
        */
        /// 
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int RomainToInteger(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);

            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                res += GetSign(map, s, i) * map[s[i]];

            }
            return res;
        }

        /// <summary>
        /// method to figure out if the current number should be negative.
        /// </summary>
        /// <param name="map"></param>
        /// <param name="s"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        private int GetSign(Dictionary<char, int> map, string s, int i)
        {
            if (i == s.Length - 1) return 1;
            if (map[s[i]] < map[s[i + 1]])
            {
                return -1;
            }
            else
            {
                return 1;
            } 
        }
    }
}
