﻿namespace HashTableCB
{
    public class HashTableCodeBlog<T>
    {
        private T[] items;

        public HashTableCodeBlog(int size)
        {
            items = new T[size];

        }

        public void Add(T item)
        {
            var key = GetHash(item);
            items[key] = item;
        }

        public bool Search(T item)
        {
            var key = (int)GetHash(item);
            return items[key].Equals(item);
        }

        private int GetHash(T item)
        {
            return item.ToString().Length % items.Length - 1;
        }

    }
}
