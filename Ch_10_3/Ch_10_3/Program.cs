using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee()
            {
                Name = "v1",
                Age = 22
            };
            //эквивалентно
            var employee2 = new Employee();
            employee2.Name = "v2";
            employee2.Age = 22;
           

        }
    }
}
