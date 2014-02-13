using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftQuestions
{
    public class _001_LongestSubString
    {
        /*
        一个String当中，求出现多于一次的最长的substring。
        eg: "abcabcaacb" -> "abca"
        eg: "aababa" -> "aba"
         */
        public string FindLongestSubString(string s)
        {
            TrieNode root = new TrieNode()
            {
                Children = new List<TrieNode>()
            };

            string res = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                string tmp = InsertToTrie(root, s.Substring(i));
                res = tmp.Length > res.Length ? tmp : res;
            }

            return res;
        }

        public string InsertToTrie(TrieNode root, string s)
        {
            //base case.
            if (s.Length == 0) return string.Empty;

            // if s[0] can be found in child, recursive to find more.
            foreach (TrieNode node in root.Children)
            {
                if (node.Value == s[0])
                {
                    return s[0] + InsertToTrie(node, s.Substring(1));
                }
            }

            // if can not be found in this node's children
            // begin to add it. and recursively add the rest of string.
            TrieNode newNode = new TrieNode()
            {
                Value = s[0],
                Children = new List<TrieNode>()
            };
            root.Children.Add(newNode);
            InsertToTrie(newNode, s.Substring(1));
            return string.Empty;
        }
    }
}
