using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_6_2
{
    class ClosedClass1
    {
        public sealed override bool Equals(object obj)
        {
            return base.Equals(obj);
        }


        public sealed override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public sealed override string ToString()
        {
            return base.ToString();
        }
    }
}
