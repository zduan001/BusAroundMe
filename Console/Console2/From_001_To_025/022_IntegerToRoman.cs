using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _022_IntegerToRoman
    {
        /*
        Given an integer, convert it to a roman numeral.
        Input is guaranteed to be within the range from 1 to 3999.
        */
        /// <summary>
        /// this method use a look up table, so it is relative easy.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public string IntegertoRoman(int i)
        {
            string[,] RomanLetters= new string[,]{
                {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" },
                { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" },
                { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" },
                { "M", "MM", "MMM", "", "", "", "", "", ""  }
            };
            int[] digits = new int[4];
            for(int j = 0; j< digits.Length;j++)
            {
                digits[j] = i%10;
                i = i/10;
            }

            string res = string.Empty;

            for(int j = 0;j< digits.Length;j++)
            {
                res = RomanLetters[j, digits[j]-1] + res;
            }

            return res;
        }
    }
}
