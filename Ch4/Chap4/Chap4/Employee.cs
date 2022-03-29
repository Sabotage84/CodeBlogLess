using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4
{
    class Employee
    {
        int a;
        public Employee()
        {
            a = 5;
        }
        public Employee(int _a)
        {
            a = _a;
        }

        public void CallEpmloyee()
        {
            Console.WriteLine("Emploee class!");
        }
    }
}
