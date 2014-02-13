using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookQuestions
{
    public class _006_Intervals
    {
        /*
         * Giving lots of intervals [ai; bi], find a point intersect with the most number of intervals
         * need O(nlgn)
         * http://www.mitbbs.com/article_t/JobHunting/32063239.html
         * this is a very smart way:
         * 把所有ai, bi合起来排序每点保留记号标明是a还是b,2nlog(2n)(还算O(nlogn)吧),然后从头扫描到尾,
         * 碰到a计数加一,碰到b减一,假设计数最大的点在位置k,那么要找的点就在k与k+1之间.
         */
    }
}
