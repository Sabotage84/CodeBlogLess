using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();

			Console.WriteLine(obj.ToString());
			Console.WriteLine("Test!");
			Console.ReadLine();
        }
		/*
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			RuntimeType runtimeType = (RuntimeType)base.GetType();
			RuntimeType left = (RuntimeType)obj.GetType();
			if (left != runtimeType)
			{
				return false;
			}
			if (ValueType.CanCompareBits(this))
			{
				return ValueType.FastEqualsCheck(this, obj);
			}
			FieldInfo[] fields = runtimeType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			for (int i = 0; i < fields.Length; i++)
			{
				object obj2 = ((RtFieldInfo)fields[i]).InternalGetValue(this, false);
				object obj3 = ((RtFieldInfo)fields[i]).InternalGetValue(obj, false);
				if (obj2 == null)
				{
					if (obj3 != null)
					{
						return false;
					}
				}
				else
				{
					if (!obj2.Equals(obj3))
					{
						return false;
					}
				}
			}
			return true;
		}
		*/
	}
}
