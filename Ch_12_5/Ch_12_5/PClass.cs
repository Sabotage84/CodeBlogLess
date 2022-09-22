using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_12_5
{
    public class PClass<TKey,TValue>//CLR не знает какие типы будут тут, открытый тип
                                    //(нельзя создавать экз. без указания типа)
    {
        TKey i;

        public TValue GetValue(TKey key)
        {
            return default(TValue);
        }
    }
}
