using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_6_2
{
    class Employee
    {
        public int GetYearsEmployee()
        {
            return 42;
        }

        public virtual string GetProgressreport()
        {
            return "Good!";
        }

        public static Employee LookUp(string name)
        {
            return null;
        }
    }
}
