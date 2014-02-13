using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_051_To_75
{
    public class _062_RomanToInteger
    {
        /*
         * Given a roman numeral, convert it to an integer.Input is guaranteed to be within the range from 1 to 3999.
         */
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
                res += GetSign(s, i, map) * map[s[i]];
            }
            return res;
        }

        public int GetSign(string s, int i, Dictionary<char, int> map)
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
