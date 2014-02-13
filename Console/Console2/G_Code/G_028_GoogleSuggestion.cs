using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    class G_028_GoogleSuggestion
    {
        /*
         * 我想基本的structure应该是trie + minheap.
        First, we need to assume that popular search phases' search frequencies are 
        known. I think this can be achieved by map reduce easily, and the result is 
        stored at a database called DB.

        Then, build a trie according to those popular search phases. Each node in 
        the trie has a pointer to a minHeap. The minHeap has a fixed size of 10. 
        Each node in minHeap stores a word and its frequency. 

        Suppose we want to insert a word craigslist into the trie, we need to update
        every node's minHeap along the path, namely c, cr, cra, crai, craig, craigs
        , craigsl, cragisli, cragislis and craigslist.

        Please note this approach builds the trie according to DB statically,
        and I think we need to reconstruct a new trie according to new DB every 
        month.
         * 
         * 
         * 
         * 方向不对，他们关心的是大规模数据，每时每刻都有新的数据进来，这些东西不能保存
        在一台机器上，计算不可能实时同步，但是又不能滞后太多。而且你需要把历史数据和
        当前热点都考虑进去。然后全球时差，中国发生大事时，美国可能在睡觉，所以需要
        roll along时区。这是G的architect这么跟我提的几点。当然那些什么edit distance,
        字/词匹配也是要考虑的。

        我当时听着就心想，谁要是不做这个方向，能考虑全这些方面，也太神了
         */
    }
}
