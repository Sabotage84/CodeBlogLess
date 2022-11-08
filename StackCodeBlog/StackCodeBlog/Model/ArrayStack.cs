using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCodeBlog.Model
{
    public class ArrayStack<T>
    {
        T[] items;
        private int current = -1;
        private int size = 10;

        public int Count => items.Length;

        public ArrayStack(int size=10)
        {
            items = new T[size];
            this.size = size;
        }

        public ArrayStack(T data, int size = 10):this(size)
        {
            items[current] = data;
            current = 1;
        }

        public void Push(T data)
        {
            if (current<size-1)
            {
                items[current] = data;
                current++;
            }
            else
            {
                throw new StackOverflowException();
            }
        }

        public T Pop()
        {
            if (current>=0)
            {
                var item = items[current];
                items[current] = default(T);
                current--;
                return item;
            }
            else
            {
                throw new NullReferenceException(); 
            }
        }

        public T Peak()
        {
            if (current >= 0)
            {
               return items[current];
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
