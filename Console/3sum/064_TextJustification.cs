using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _064_TextJustification
    {
        /// <summary>
        /// Given an array of words and a length L, format the text such that each line has exactly L characters and is fully (left and right) justified.
        /// You should pack your words in a greedy approach; that is, pack as many words as you can in each line. Pad extra spaces ' ' when necessary so that each line has exactly L characters.
        /// Extra spaces between words should be distributed as evenly as possible. If the number of spaces on a line do not divide evenly between words, the empty slots on the left will be assigned more spaces than the slots on the right.
        /// For the last line of text, it should be left justified and no extra space is inserted between words.
        /// For example,
        /// words: ["This", "is", "an", "example", "of", "text", "justification."]
        /// L: 16.
        /// Return the formatted lines as:
        /// [
        ///  "This is an",
        ///  "example of text",
        ///  "justification. "
        /// ]
        /// 
        /// Note: Each word is guaranteed not to exceed L in length.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        public List<string> TextJustification(List<string> words, int l)
        {
            List<string> res = new List<string>();
            List<List<string>> lines = new List<List<string>>();
            int lineLength = 0;
            int lineStartIndex = 0;
            int lineEndIndex = 0;

            for (int i = 0; i < words.Count; i++)
            {
                lineLength += words[i].Length;
                if (lineLength > l)
                {
                    List<string> newLine = new List<string>();
                    for (int j = lineStartIndex; j <= lineEndIndex; j++)
                    {
                        newLine.Add(words[j]);
                    }
                    lines.Add(newLine);
                    lineStartIndex = i;
                    lineEndIndex = i;
                    lineLength = words[i].Length;
                }
                lineLength++;
                lineEndIndex = i;
                if (i == words.Count - 1)
                {
                    List<string> newLine = new List<string>();
                    for (int j = lineStartIndex; j <= lineEndIndex; j++)
                    {
                        newLine.Add(words[j]);
                    }
                    lines.Add(newLine);
                }
            }

            for( int j = 0; j < lines.Count-1; j++)
            {
                List<string> line = lines[j];
                if (line.Count > 1)
                {
                    int charLength = 0;
                    foreach (string s in line)
                    {
                        charLength += s.Length;
                    }

                    int spacesCount = l - charLength;
                    int evenSpace = spacesCount / (line.Count - 1);
                    int module = spacesCount % (line.Count - 1);
                    StringBuilder sb = new StringBuilder();

                    foreach (string s in line)
                    {
                        if (sb.Length > 0)
                        {
                            for (int i = 0; i < evenSpace; i++)
                            {
                                sb.Append(" ");
                            }
                            if (module > 0)
                            {
                                sb.Append(" ");
                                module--;
                            }
                        }
                        sb.Append(s);
                    }
                    res.Add(sb.ToString());
                }
                else
                {
                    res.Add(line[j]);
                }
            }

            StringBuilder sbLast = new StringBuilder();
            foreach (string s in lines[lines.Count - 1])
            {
                if (sbLast.Length != 0)
                {
                    sbLast.Append(" ");
                }
                sbLast.Append(s);
            }
            res.Add(sbLast.ToString());

            return res;
        }
    }
}
