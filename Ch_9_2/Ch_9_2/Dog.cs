using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_9_2
{
    public class Dog
    {
        string name;

        public string Name { get => name; set => name = value; }

        public Dog(string s)
        {
            name = s;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
