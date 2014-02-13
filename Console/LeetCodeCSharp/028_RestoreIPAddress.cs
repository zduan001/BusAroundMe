using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _028_RestoreIPAddress
    {
        /*
         * http://leetcode.com/onlinejudge#question_93
         */
        public List<string> RestoreIPAddress(string input)
        {
            List<string> res = new List<string>();
            string progress = string.Empty;
            int level = 3;
            RestoreIPAddress(input, progress, level, res);
            return res;
        }

        private void RestoreIPAddress(string input, string progress, int level, List<string> res)
        {
            int value;
            if (level >= 0)
            {
                if (level == 0 && !string.IsNullOrEmpty(input) && int.TryParse(input, out value))
                {
                    if (value <= 255)
                    {
                        progress += "." + input;
                        res.Add(progress);
                        return;
                    }
                }
                else
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        if (i < input.Length && int.TryParse(input.Substring(0, i), out value) && value <= 255)
                        {
                            string orginalStr = progress;
                            progress += string.IsNullOrEmpty(progress) ? string.Empty : ".";
                            progress += input.Substring(0, i);
                            RestoreIPAddress(input.Substring(i), progress, level - 1, res);
                            progress = orginalStr;
                        }
                    }
                }
            }
        }
    }
}
