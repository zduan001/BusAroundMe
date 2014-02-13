using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _055_ScrambleString
    {
        /*
            Given a string s1, we may represent it as a binary tree by partitioning it to two non-empty substrings recursively.
            Below is one possible representation of s1 = "great":
             great
　             / \
             gr eat
             / \ / \
            g r e at
　　              / \
                   a t
            To scramble the string, we may choose any non-leaf node and swap its two children.
            For example, if we choose the node "gr" and swap its two children, it produces a scrambled string "rgeat".
             rgeat
               / \
             rg eat
             / \ / \
            r g e at
                   / \
                   a t
            We say that "rgeat" is a scrambled string of "great".
            Similarly, if we continue to swap the children of nodes "eat" and "at", it produces a scrambled string "rgtae".
             rgtae
               / \
             rg tae
             / \ / \
            r g ta e
                 / \
                 t a
            We say that "rgtae" is a scrambled string of "great".
            Given two strings s1 and s2 of the same length, determine if s2 is a scrambled string of s1.
         * 
         * "abcd", "dabc" true     
            "abcd", "dacb" true     
            "abcd", "dbac" true     
            "abcd", "dbca" true     
            "abcd", "dcab" true     
            "abcd", "dcba" true     
            "dcba", "abcd" true     
            "abcd", "bdac" false     
            "bdac", "abcd" false     
            "abcd", "cadb" false     
            "cadb", "abcd" false     
            "abcdd", "dbdac" false     
            "dbdac", "abcdd" false 
         */


        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool IsScrambleString(string s1, string s2)
        {
            if (s1 == s2)
            {
                return true;
            }
            else if (s1.Length != s2.Length)
            {
                return false;
            }
            else if (s1.Length == 1 && s1 != s2)
            {
                return false;
            }
            else
            {
                for (int i = 1; i < s1.Length; i++)
                {
                    if ((IsScrambleString(s1.Substring(0, i), s2.Substring(0, i)) && IsScrambleString(s1.Substring(i), s2.Substring(i))) ||
                        (IsScrambleString(s1.Substring(0, i), s2.Substring(s2.Length - i)) && IsScrambleString(s1.Substring(s1.Length - i), s2.Substring(0,i))))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// copied online same idea, but code does not work, it has bug.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool ScrambleString(string s1, string s2)
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
                        ScrambleString(s1.Substring(0, i), s2.Substring(s2.Length - i)) && ScrambleString(s1.Substring(s1.Length-i), s2.Substring(i)))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
