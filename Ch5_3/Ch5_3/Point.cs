using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_3
{
    struct Point:IComparable,IChangePoint
    {
        public int x;
        public int y;
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public override string ToString()
        {
            string s = string.Format("{0} {1}", x, y);
            return s;
        }

        public int CompareTo(object obj)
        {
            return -1;
        }

        public void Change(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public int CompareTo(Point p2)
        {
            return -1;
        }
    }
}
