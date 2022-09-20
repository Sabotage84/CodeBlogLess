using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_12_5
{
    public class PClass<TKey,TValue>
    {
        TKey i;

        public TValue GetValue(TKey key)
        {
            return default(TValue);
        }
    }
}
