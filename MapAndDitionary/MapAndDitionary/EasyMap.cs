using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace MapAndDitionary
{
    internal class EasyMap<TKey, TValue>
    {
        private List<Item<TKey, TValue>> Items= new List<Item<TKey, TValue>>();
        private List<TKey> Keys= new List<TKey>();

        public int Count => Items.Count;

        public EasyMap() 
        {
            
        }

        public void Add(Item<TKey, TValue> item)
        {
            if (!Keys.Contains(item.Key))
            {
                Keys.Add(item.Key);
                Items.Add(item);
            }

        }

        public TValue Search(TKey key)
        {
            if(Keys.Contains(key))
            {
                return Items.Single(i => i.Key.Equals(key)).Value;
            }
            return default(TValue);//или исключение
        }

        public void Remove(TKey key)
        {
            if (Keys.Contains(key))
            {   
                Keys.Remove(key);
                Items.Remove(Items.Single(i => i.Key.Equals(key)));
            }
            
        }
    }
}
