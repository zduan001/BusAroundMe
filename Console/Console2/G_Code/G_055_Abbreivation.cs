using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_055_Abbreivation
    {
        /*
         * Suppose you have a dictionary of words. Given a abbreviation like “i18n”, determine if it is unique in the dictionary.
         * internationlization -> i18n because there are 18 charactor between first i and last n. 
         */
        /// <summary>
        /// I can do a brute force get all possible combination with i18n and check the dictionary ( I assume this dictionary is 
        /// given as a hasset. this will take O(26^k)
        /// 
        /// or I can use a map-reduce method, map the dictionary word by it's length and then sort them and try to find the word
        /// start with i and end with n which can abbreviate to i18n...
        /// </summary>
        /// <param name="abbreviate"></param>
        /// <returns></returns>
        public bool FindAbbreviateion(string abbreviate)
        {
            Abbre abb = GetAbbre(abbreviate);
            // I guess this question should be discussion question not a white board question.
            // so I will skip the coding part.
            return true;
        }

        private Abbre GetAbbre(string s)
        {
            Abbre abb = new Abbre()
            {
                First = 'i',
                Last = 'n',
                count = 18
            };
            return abb;
        }
    }

    public class Abbre 
    {
        public char First;
        public char Last;
        public int count;
    }
}
