using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _003_IsWord
    {
        /* Difficulty: ***
         * 给定bool isWord(string s) create function to print all words based on a string.
            For example, input: “thisisdesktop”
            output is: “this is desk top”, “this is desktop”
         * http://www.mitbbs.com/article_t/JobHunting/32267935.html
         * I havn't test this code yet. but it should work. 
         */
        public List<string> FindAllSentences(string input, HashSet<string> dictionary)
        {
            List<string> res = new List<string>();
            bool[] tracker = new bool[input.Length - 1];
            WorkerMethod(input, tracker, 0, res, dictionary);
            return res;
        }

        private void WorkerMethod(string input, bool[] tracker, int k, List<string> res, HashSet<string> dictionary)
        {
            string tmp = VerifySentence(input, tracker, dictionary);
            if (!string.IsNullOrWhiteSpace(tmp))
            {
                res.Add(tmp);
            }

            for (int i = k; i < tracker.Length; i++)
            {
                tracker[i] = true;
                WorkerMethod(input, tracker, i + 1, res, dictionary);
                tracker[i] = false;
            }
        }

        private string VerifySentence(string input, bool[] tracker, HashSet<string> dictionary)
        {
            StringBuilder sb = new StringBuilder();
            int previousIndex = 0;
            for (int i = 0; i < tracker.Length; i++)
            {
                if (tracker[i])
                {
                    string tmp = input.Substring(previousIndex, i - previousIndex + 1);
                    if (dictionary.Contains(tmp))
                    {
                        sb.Append(" ");
                        sb.Append(tmp);
                        previousIndex = i + 1;
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            if (previousIndex < input.Length)
            {
                string tmp = input.Substring(previousIndex);
                if (dictionary.Contains(tmp))
                {
                    sb.Append(" ");
                    sb.Append(tmp);
                }
                else
                {
                    return string.Empty;
                }
            }

            return sb.ToString();
        }

        public bool IsWord(string input, HashSet<string> dictionary)
        {
            bool[] tracker = new bool[input.Length];

            for (int i = 1; i < input.Length; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        if (dictionary.Contains(input.Substring(0, i + 1)))
                        {
                            tracker[i] = true;
                            break;
                        }
                    }
                    else
                    {
                        if (tracker[j - 1] && dictionary.Contains(input.Substring(j, i - j + 1)))
                        {
                            tracker[i] = true;
                            break;
                        }
                    }
                }
            }
            return tracker[input.Length - 1];
        }

        public bool IsWordRecursive(string input, HashSet<string> dictionary)
        {
            if (string.IsNullOrEmpty(input)) return true;
            for (int i = 1; i <= input.Length; i++)
            {
                if (dictionary.Contains(input.Substring(0, i)))
                {
                    return IsWordRecursive(input.Substring(i), dictionary);
                }
            }
            return false;
        }
    }
}
