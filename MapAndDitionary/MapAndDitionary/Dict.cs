using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapAndDitionary
{
    internal class Dict<TKey, TValue>: IEnumerable
    {
        private int size = 100;
        private Item<TKey, TValue>[] Items;
        private List<TKey> Keys = new List<TKey>();

        public Dict()
        {
            Items = new Item<TKey, TValue>[100];
        }

        public void Add(Item<TKey, TValue> item) 
        {
            var hash = GetHash(item.Key);

            if(Keys.Contains(item.Key))
            {
                return;
            }

            if (Items[hash]==null) 
            {
                Keys.Add(item.Key);
                Items[hash] = item;
            }
            else
            {
                var placed = false;
                for (var i = hash; i < size; i++)
                {
                    if (Items[i]==null)
                    {
                        Items[i]=item;
                        Keys.Add(item.Key);
                        placed = true;
                        break;
                    }
                    if (Items[i].Key.Equals(item.Key))
                    {
                        return;
                    }

                    

                }
                if (!placed)
                {
                    for (var i = 0; i < hash; i++)
                    {
                        if (Items[i] == null)
                        {
                            Items[i] = item;
                            placed = true;
                            Keys.Add(item.Key);
                            break;
                        }
                        if (Items[i].Key.Equals(item.Key))
                        {
                            return;
                        }

                        

                    }
                }
                if(!placed)
                {
                    throw new Exception("Dict is full!");  
                }
            }

        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in Items)
            {
                if(item!=null)
                {
                    yield return item;
                }
            }
        }

        public void Remove(TKey key)
        {
            var hash = GetHash(key);
            if (!Keys.Contains(key))
            {
                return;
            }
            

            if (Items[hash] != null && Items[hash].Key.Equals(key))
            {
                Keys.Remove(key);
                Items[hash] = null;
                return;
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (Items[i] != null && Items[i].Key.Equals(key))
                    {
                        Keys.Remove(key);
                        Items[i] = null;
                        return;
                    }
                }
               
            }
        }

        public TValue Search(TKey key)//не работает как надо
            //нужно добавить список ключей и проверять его
        {
            var hash = GetHash(key);
            if (!Keys.Contains(key))
            {
                return default(TValue); ;
            }


            if (Items[hash]!=null && Items[hash].Key.Equals(key))
            {
                Keys.Remove(key);
                return Items[hash].Value;
               
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (Items[i] != null && Items[i].Key.Equals(key))
                    {
                        Keys.Remove(key);
                        return Items[i].Value;
                    }
                }

            }

            return default(TValue);
        }

        private int GetHash(TKey key)
        {
            return key.GetHashCode()%size;
        }

        public void Show()
        {
            foreach (var item in Items)
            {
                if (item != null)
                {
                    Console.WriteLine(item.Value+" ");
                }
            }
            Console.WriteLine();
        }

    }
}
