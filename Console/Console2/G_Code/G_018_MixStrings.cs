using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_018_MixStrings
    {
        /*
         * there are 2 list of strings. mix charactors in the strings until one string is run out of charactors
         */

        public string MixStrings(List<string> l1, List<string> l2)
        {
            StringIterator si1 = new StringIterator(l1);
            StringIterator si2 = new StringIterator(l2);
            StringBuilder sb = new StringBuilder();
            while (si1.HasNext() && si2.HasNext())
            {
                sb.Append(si1.GetNext()).Append(si2.GetNext());
            }

            return sb.ToString();
        }
    }

    public class StringIterator
    {
        public StringIterator(List<string> input)
        {
            list = input;
            StrIndex = 0;
            CharactorIndex = 0;
        }
        int StrIndex;
        int CharactorIndex;
        List<string> list;

        public bool HasNext()
        {
            if (StrIndex< list.Count && CharactorIndex < list[StrIndex].Length)
            {
                return true;
            }
            else
            {
                if (StrIndex < list.Count-1)
                {
                    StrIndex++;
                    CharactorIndex = 0;
                    return this.HasNext();
                }
                else
                {
                    return false;
                }
            }
        }

        public Char? GetNext()
        {
            if(HasNext())
            {
                char c = list[StrIndex][CharactorIndex];
                CharactorIndex++;
                this.HasNext();
                return c;
            }
            return null;
             
        }
    }
}
