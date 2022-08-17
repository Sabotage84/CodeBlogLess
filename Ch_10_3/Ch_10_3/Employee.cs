using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_10_3
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get;  set; }

        public override string ToString()
        {
            return Name;
        }
        public Employee()
        {

        }
        public Employee(string n)

        {
            Name = n;
        }
    }
}
