using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_043_FindRealtives
    {
        /*
         * Find a connection between two people if there is one, or return false. Everyone has father and mother 
         * and the connection means if there are any common relatives.
         * http://www.mitbbs.com/article_t/JobHunting/32197927.html
         */

        public bool IsRelative(Person p1, Person p2)
        {
            HashSet<Person> searched = new HashSet<Person>();
            return SearchRelative(p1, p2, searched);

        }

        public bool SearchRelative(Person p1, Person p2, HashSet<Person> searching)
        {
            if (p1 == p2)
            {
                return true;
            }
            else
            {
                foreach(Person p in p1.Relatives)
                {
                    if (!searching.Contains(p))
                    {
                        searching.Add(p);
                        if(SearchRelative(p, p2, searching))
                        {
                            return true;
                        }

                    }
                }
                return false;
            }
        }
    }

    public class Person
    {
        public List<Person> Relatives;
    }
}
