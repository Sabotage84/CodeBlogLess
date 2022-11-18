using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCodeBlog
{
    public class EasySet<T>
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
    }
}
