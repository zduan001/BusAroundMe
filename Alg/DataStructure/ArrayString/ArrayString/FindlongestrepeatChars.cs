using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class FindlongestrepeatChars
    {
        /*
         * "this is a sentence" => [t, h, i, s, i, s, a, s, e, n, t, e, n, c, e]
        "thiis iss a senntencee" => [i, s, n, e]
        "thiisss iss a senntttenceee" => [s, t, e]
        "thiisss iss a sennnntttenceee" => [n]
         */
        public string LongestRepeat(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            List<KeyValuePair<char, int>> mainPair = new List<KeyValuePair<char, int>>();

            int i = 0;
            char currentChar = '-';
            int currenCount = 0;
            int maxcount = 0;

            while (i < input.Length)
            {
                if (currentChar == input[i])
                {
                    currenCount++;
                }
                else
                {
                    mainPair.Add(new KeyValuePair<char, int>(currentChar, currenCount));
                    maxcount = maxcount > currenCount ? maxcount : currenCount;
                    currentChar = input[i];
                    currenCount = 1;
                }
                i++;
            }
            mainPair.Add(new KeyValuePair<char, int>(currentChar, currenCount));
            maxcount = maxcount > currenCount ? maxcount : currenCount;
           
            StringBuilder sb = new StringBuilder();
            for(int j = 0;j< mainPair.Count;j++)
            {
                if (mainPair[j].Value == maxcount && mainPair[j].Key != ' ' )
                {
                    sb.Append(mainPair[j].Key);
                }
            }

            return sb.ToString();
        }
    }
}
