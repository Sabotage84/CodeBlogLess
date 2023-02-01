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
            trie.Add("hello", 50);
            trie.Add("hell", 100);
            trie.Add("hellfire", 150);
            trie.Add("work", 50);
            trie.Add("world", 100);
            trie.Add("wrong", 150);
            trie.Add("code", 50);
            trie.Add("cat", 100);
            trie.Add("catana", 150);

            trie.Remove("hello");
            trie.Remove("catana");
            trie.Remove("work");
            
            Search(trie, "hello");
            Search(trie, "catana");
            Search(trie, "work");
            Search(trie, "hell");
            Search(trie, "code");

            Console.ReadLine();

        }

        private static void Search(Trie<int> trie, string word)
        {
            if (trie.TrySearch(word, out int value))
            {
                Console.WriteLine(word+" "+value);
            }
            else
            {
                Console.WriteLine("Не найдено!");
            }
        }
    }
}
