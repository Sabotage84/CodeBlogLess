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

    public class PPClass<TKey> : PClass <TKey,string>//Пока все типы не определены, класс открытый
    {

    }

    public class DictionaryString<TValue>:Dictionary<string, TValue>
    {

    }

}
