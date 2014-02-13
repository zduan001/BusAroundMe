using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra
{
    public class TrieNode
    {
        public char Value;
        public List<TrieNode> Children;
        public bool IsWord;
    }
}
