using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class SaveHumanity
    {
        public List<int> FindMatch(string p, string v)
        {

            if (v.Length > p.Length) return null;
            List<int> res = new List<int>();
            int mismatchcount = 0;
            int j = 0;
            for (int i = 0; i < p.Length - v.Length; i++)
            {
                mismatchcount = 0;
                j = 0;
                while(j< v.Length)
                {
                    if (p[i+j] != p[j])
                    {
                        if (mismatchcount != 0)
                            break;
                        else
                        {
                            mismatchcount++;
                        }

                    }
                    j++;
                }
                if (j == v.Length)
                {
                    res.Add(i);
                }
            }

            return res;

        }
    }
}
