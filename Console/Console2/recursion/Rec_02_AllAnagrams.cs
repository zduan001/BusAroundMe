using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.recursion
{
    public class Rec_02_AllAnagrams
    {
        /*
         * Get all anagrams of a string
         */
        public List<string> GetAllAnagrams(string s)
        {
            List<string> res = new List<string>();
            FinDAnagrams(s.Length, 0, s, string.Empty, new bool[s.Length], res);
            return res;
        }

        private void FinDAnagrams(int n, int k, string input, string output, bool[] tracker, List<string> res)
        {
            if (n == k)
            {
                res.Add(output);
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!tracker[i])
                    {
                        tracker[i] = true;
                        FinDAnagrams(n, k + 1, input, output + input[i], tracker, res);
                        tracker[i] = false;
                    }
                }
            }
        }

        /*
         Write a function using Recursion to display all anagrams of a string entered by the user, in such a way that all 
         its vowels are located at the end of every anagram. (E.g.: Recursion => Rcrsneuio, cRsnroieu, etc.) Optimize it.
         */
        public List<string> GetAllAnagramsVolAtEnd(string s)
        {
            List<string> res = new List<string>();
            FinDAnagramsVolAtEnd(s.Length, 0, s, string.Empty, new bool[s.Length], res);
            return res;

        }

        private void FinDAnagramsVolAtEnd(int n, int k, string input, string output, bool[] tracker, List<string> res)
        {
            if (n == k)
            {
                if (IsAllVolAtEnd(output))
                {
                    res.Add(output);
                }
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!tracker[i])
                    {
                        tracker[i] = true;
                        FinDAnagramsVolAtEnd(n, k + 1, input, output + input[i], tracker, res);
                        tracker[i] = false;
                    }
                }
            }
        }

        private bool IsAllVolAtEnd(string s)
        {
            int pivot = -1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if ((s[i] != 'i' || s[i] != 'a' || s[i] != 'e' || s[i] != 'o' || s[i] != 'u') && pivot == -1)
                {
                    pivot = i;
                }
                if ((s[i] == 'i' || s[i] == 'a' || s[i] == 'e' || s[i] == 'o' || s[i] == 'u') && i < pivot)
                {
                    return false;
                }
            }
            return true;
        }



        /*
         * Write a function using Recursion to do the following: You have 20 different cards. You have only 7 envelopes. 
         * You can therefore send only 7 cards. Display all possible ways you can fill the 7 envelopes. (Every card is different)
         */
        public List<List<int>> GetCardCombination(int n, int k)
        {
            List<List<int>> res = new List<List<int>>();
            bool[] tracker = new bool[n];
            WorkerCardCombination(n, k, 0, new List<int>(), tracker, res);
            return res;
        }

        public void WorkerCardCombination(int n, int k, int l, List<int> input, bool[] tracker, List<List<int>> res)
        {
            if(l==k)
            {
                List<int> tmp = new List<int>(input);
                res.Add(tmp);
                return;
            }else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!tracker[i])
                    {
                        tracker[i] = true;
                        input.Add(i);
                        WorkerCardCombination(n, k, l + 1, input, tracker, res);
                        input.Remove(i);
                        tracker[i] = false;
                    }
                }
            }
        }

        /*
         * Write a function using Recursion to crack a password. The password is of unknown length (maximum 10) and 
         * is made up of capital letters and digits. (Store the actual password in your program, just for checking 
         * whether the string currently obtained is the right password.)
         */
        public bool CrackPassword(string password)
        {
            char[] chars = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            int maxLength = 10;
            string res = PasswordWorker(maxLength, 0, chars, string.Empty, password);
            if (res != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string PasswordWorker(int n, int k, char[] chars, string s, string passWord)
        {
            if ( k<=n)
            {
                if (s == passWord)
                {
                    return s;
                }
                else
                {
                    if (k == n)
                    {
                        return string.Empty;
                    }
                }
            }

                for (int i = 0; i < chars.Length; i++)
                {
                    string res = PasswordWorker(n, k + 1, chars, s + chars[i], passWord);
                    if (res != string.Empty)
                    {
                        return res;
                    }
                }
            
            return string.Empty;
        }
    }
}
