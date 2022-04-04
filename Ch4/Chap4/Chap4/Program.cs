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
			// Приведение
			bool b1 = obj is object;   // true
			bool b2 = obj is Employee;//False


			// IS and AS
			if (obj is Employee)
            {
				Employee e = (Employee)obj;//too long
            }

			Employee ee = obj as Employee;// null or New employee


			// Bad meth
			Manager m = new Manager();
			PromoteEmployee(m);// all good

			PromoteEmployee(obj);//Runtime error!!!!!!!!

			M3();

			Console.WriteLine(obj.ToString());
			Console.WriteLine("Test!");
			Console.ReadLine();
        }

		static void PromoteEmployee(object o)
        {
			//Employee e1 = (Employee)o; //possible runtime error
        }

		void M1()
        {
			string name = "Joe"; //name в стек 
			M2(name);// в стек точка возврата, вызов м2
        }

		void M2(string n)//переменная n ссылается на тоже что и name
        {
			int length = n.Length;//стек заполняется переменными 
			int tally;//из вызванного метода м2
        }//выход и возвращение стека на точку возврата в м1
											//стек			куча
		static void M3()					//				
        {									//					
			Employee e;                     // e=null			
			int year;						// year=0			
			e = new Manager();				//				создание объекта Manager->Ссылка на объект, блок синхронизации, поля, статики, методы.
			e = Employee.Lookup("Joe");		//joe,			сщздание еще одного manager и присвоение e новому объекту, старый manager скоро будет удален
											//запомнили точку возврата				
			year = e.GetYearEmployed();		//вызывается метод из emploee year=5							
			e.CallEpmloyee();               //	вызывается метод из manager так как e ссылается на объект тип manager
			e.foo();						//вызывается emploee метод почему???

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
