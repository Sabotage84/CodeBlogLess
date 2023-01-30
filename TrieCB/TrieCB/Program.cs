using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieCB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var trie = new Trie<int>();
            trie.Add("Hello",50);
            trie.Add("World",100);
            trie.Add("Hellfire",150);
        }
    }
}
