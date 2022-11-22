using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCodeBlog
{
    public class EasySet<T>: IEnumerable
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public EasySet()
        {

        }
        public EasySet(T item)
        {
            items.Add(item);
        }

        public EasySet(IEnumerable<T> items)
        {
            this.items = items.ToList();
        }

        public void Add(T item)
        {
            foreach (var i in items)
            {
                if (i.Equals(item))
                {
                    return;
                }
            }
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public EasySet<T> Union(EasySet<T> set)
        {
            //return this.Union(set);

            //return new EasySet<T>(items.Union(set.items));

            EasySet<T> result= new EasySet<T>();

            if (Count >= set.Count)
            {
                result.items.AddRange(items);

                foreach (var item in set.items)
                {
                    result.Add(item);
                }
            }
            else
            {
                result.items.AddRange(set.items);

                foreach (var item in items)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public EasySet<T> Intersection(EasySet<T> set)
        {
            var result = new EasySet<T>();

            foreach (var item1 in items)
            {
                foreach (var item2 in set.items)
                {
                    if(item1.Equals(item2))
                    {
                        result.Add(item1);
                        break;
                    }
                }
            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public void Show()
        {
            foreach (var item in items)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
