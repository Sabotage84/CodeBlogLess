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

        public EasySet<T> Difference(EasySet<T> set)
        {
            var result = new EasySet<T>(items);
            foreach (var item in set.items)
            {
                result.Remove(item);
            }
            return result;
        }

        public bool Subset(EasySet<T> set)
        {

            foreach (var item1 in set.items)
            {
                var equals = false;
                foreach (var item2 in items)
                {
                    if(item1.Equals(item2))
                    {
                        equals = true;
                        break;
                    }
                }
                if(!equals)
                {
                    return false;
                }
            }
            return true;
        }


        public EasySet<T> SymmetricDifference(EasySet<T> set)
        {

            //return new EasySet<T>(items.Except(set.items).Union(set.items.Except(items)));

            var res = new EasySet<T>();
            var res1=set.Difference(this);
            var res2 =this.Difference(set);
            res = res1.Union(res2);
            return res;


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
