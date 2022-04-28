using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_3
{
    class TestClass : IComparable<TestClass>, IComparable, IEquatable<TestClass>
    {
        int t1;
        int t2;

        string s1;

        public int CompareTo(TestClass other)
        {
            if (t1.CompareTo(other.t1)==0)
            {
                if (s1.Length.CompareTo(other.s1.Length)==0)
                {
                    return t2.CompareTo(other.t2);
                }
                else
                {
                    return s1.Length.CompareTo(other.s1.Length);
                }
            }
            else
            {
                return t1.CompareTo(other.t1);
            }
        }

        public int CompareTo(object obj)
        {
            if (obj is TestClass)
            {
                TestClass t = obj as TestClass;
                return CompareTo(t);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public bool Equals(TestClass other)
        {
            if (CompareTo(other) == 0)
                return true;
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj is TestClass)
            {
                TestClass t = obj as TestClass;
                return Equals(t);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override int GetHashCode()
        {
            int hashCode = 732646074;
            hashCode = hashCode * -1521134295 + t1.GetHashCode();
            hashCode = hashCode * -1521134295 + t2.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(s1);
            return hashCode;
        }
    }

    
}
