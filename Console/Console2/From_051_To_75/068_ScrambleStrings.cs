using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_051_To_75
{
    public class _068_ScrambleStrings
    {
        /*
         * Below is one possible representation of s1 = "great": 
            great
           /    \
          gr    eat
         / \    /  \
        g   r  e   at
                   / \
                  a   t
 
        To scramble the string, we may choose any non-leaf node and swap its two children.
 
        For example, if we choose the node "gr" and swap its two children, it produces a scrambled string "rgeat".
            rgeat
           /    \
          rg    eat
         / \    /  \
        r   g  e   at
                   / \
                  a   t
 
        We say that "rgeat" is a scrambled string of "great". 

        Similarly, if we continue to swap the children of nodes "eat" and "at", it produces a scrambled string "rgtae".
            rgtae
           /    \
          rg    tae
         / \    /  \
        r   g  ta  e
               / \
              t   a
 
        We say that "rgtae" is a scrambled string of "great". 

         */
        /// <summary>
        /// did not do very well on first try. the problem was I was still trying to compare the whole string at the end of recursion
        /// but actually I do not have to. I have separate each string into 2 parts and if both these 2 part are scramble and then 
        /// the whole string is a scramble.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool VerifyIsScrambleStrings(string s1, string s2)
        {
            if (s1 == s2) return true;
            if (s1.Length != s2.Length) return false;

            for (int i = 1; i < s1.Length; i++)
            {
                if ((VerifyIsScrambleStrings(s1.Substring(0, i), s2.Substring(0, i)) && VerifyIsScrambleStrings(s1.Substring(i), s2.Substring(i))) ||
                    (VerifyIsScrambleStrings(s1.Substring(0, i), s2.Substring(s2.Length-i)) && VerifyIsScrambleStrings(s1.Substring(i), s2.Substring(0, s2.Length-i))))
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// this is a much better way to do the recursive......
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool ScrambleString(string s1, string s2)
        {
            if (s1 == s2)
                return true;
            else if (s1.Length != s2.Length)
                return false;
            else if (s1.Length == 1 && s1 != s2)
                return false;
            else
            {
                for (int i = 1; i < s1.Length; i++)
                {
                    if ((ScrambleString(s1.Substring(0, i), s2.Substring(0, i)) && ScrambleString(s1.Substring(i), s2.Substring(i))) ||
                        ScrambleString(s1.Substring(0, i), s2.Substring(s2.Length - i)) && ScrambleString(s1.Substring(i), s2.Substring(0, s2.Length - i)))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

    }
}
