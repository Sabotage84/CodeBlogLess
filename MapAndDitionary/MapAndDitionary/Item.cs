using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapAndDitionary
{
    internal class Item<TKey, TValue>
    {
        public TKey Key { get; set; }
        
        public TValue Value { get; set; }

        public Item(TKey key, TValue value) 
        {
            this.Key = key;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
    }
}
