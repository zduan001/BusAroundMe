using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    public class _026_PhoneNumberToWord
    {
        /*
        Given a digit string, return all possible letter combinations that the number could represent.
        A mapping of digit to letters (just like on the telephone buttons) is given below.
        Input:Digit string "23"
        Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
        Note: Although the above answer is in lexicographical order, your answer could be in any order you want.
        */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<string> PhoneNumberToWord(int input)
        {
            Dictionary<int, string[]> map = new Dictionary<int, string[]>();
            map.Add(2, new string[]{"a", "b", "c"});
            map.Add(3, new string[]{"d", "e", "f"});
            map.Add(4, new string[]{"g", "h", "i"});
            map.Add(5, new string[]{"j", "k", "l"});
            map.Add(6, new string[]{"m", "n", "o"});
            map.Add(7, new string[]{"p", "q", "r", "s"});
            map.Add(8, new string[]{"t", "u", "v"});
            map.Add(9, new string[]{"w", "x", "y", "z"});

            int i = 1;
            int tmp = 10;
            while (tmp < input)
            {
                tmp = tmp * 10;
                i++;
            }
            int[] digits = new int[i];
            for(int j = 0;j< i;j++)
            {
                digits[j] = input%10;
                input = input/10;
            }
            List<string> res = new List<string>();
            GetAllStrings(digits,0, string.Empty, res,map);
            return res;
        }

        public void GetAllStrings(int[] input, int k, string s, List<string> res, Dictionary<int, string[]> map)
        {
            if (k == input.Length)
            {
                res.Add(s);
            }
            else
            {
                for (int i = 0; i < map[input[k]].Length; i++)
                {
                    GetAllStrings(input, k + 1, s + map[input[k]][i], res, map);
                }
            }
        }
    }
}
