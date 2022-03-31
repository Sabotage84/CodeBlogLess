using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4
{
    class Employee
    {
        protected int a;
        public Employee()
        {
            a = 5;
        }
        public Employee(int _a)
        {
            a = _a;
        }

        public int GetYearEmployed()
        {
            return 5;
        }

        public virtual void CallEpmloyee()
        {
            Console.WriteLine("Emploee class!");
        }

        public static Employee Lookup(string s)
        {
            return new Manager(s);
        }

    }
}
