using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLesson
{
    public class Product:IComparable
    {
        public string Name { get; set; }

        public int Energy { get; set; }

        public int CompareTo(object obj)
        {
            Product p = obj as Product;
            return p.Energy.CompareTo(Energy);
        }

        public override string ToString()
        {
            return Name + "   " + Energy;

        }
    }
}
