using System;

namespace HashTableCB
{
    class Program
    {
        static void Main(string[] args)
        {

            var HashTable_v2 = new HashTableV2<int, string>(100);
            HashTable_v2.Add(5, "Hi");
            HashTable_v2.Add(18, "World");
            HashTable_v2.Add(777, "prog");

            Console.WriteLine(HashTable_v2.Search(6, "Vasya"));
            Console.WriteLine(HashTable_v2.Search(18, "World"));



            var badHashTable = new HashTableCodeBlog<int>(100);
            badHashTable.Add(5);
            badHashTable.Add(18);
            badHashTable.Add(777);

            Console.WriteLine(badHashTable.Search(6));
            Console.WriteLine(badHashTable.Search(18));


            Console.ReadLine();
        }
    }
}
