using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    public class Item<T>
    {
        private T data = default(T);
        private Item<T> next = null;

        public T Data
        {
            get { return data; }

            set 
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof (value));
            }
        }

        public Item<T> Next { get => next; set => next = value; }
        public Item(T data)
        {
            Data = data;
        }
    }
}
